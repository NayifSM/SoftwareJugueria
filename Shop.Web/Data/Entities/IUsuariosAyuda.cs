using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ventas.Web.Models;

namespace Ventas.Web.Data.Entities
{
    public interface IUsuariosAyuda
    {

        Task<Usuarios> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(Usuarios user, string password);
        Task<SignInResult> LoginAsync(Login model);

        Task LogoutAsync();
        Task<IdentityResult> UpdateUserAsync(Usuarios user);

        Task<IdentityResult> ChangePasswordAsync(Usuarios user, string oldPassword, string newPassword);

        Task<SignInResult> ValidatePasswordAsync(Usuarios user, string password);
        Task CheckRoleAsync(string roleName);
        Task AddUserToRoleAsync(Usuarios user, string roleName);
        Task<bool> IsUserInRoleAsync(Usuarios user, string roleName);
        Task<string> GenerateEmailConfirmationTokenAsync(Usuarios user);

        Task<IdentityResult> ConfirmEmailAsync(Usuarios user, string token);

        Task<Usuarios> GetUserByIdAsync(string userId);
        Task<string> GeneratePasswordResetTokenAsync(Usuarios user);

        Task<IdentityResult> ResetPasswordAsync(Usuarios user, string token, string password);



    }
}

