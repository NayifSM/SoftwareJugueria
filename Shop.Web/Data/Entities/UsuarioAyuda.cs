using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ventas.Web.Data.Entities;
using Ventas.Web.Models;

namespace Ventas.Web.Data
{
    public class UsuarioAyuda :IUsuariosAyuda
    {
        private readonly UserManager<Usuarios> userManager;
        private readonly SignInManager<Usuarios> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public UsuarioAyuda(
            UserManager<Usuarios> userManager,
            SignInManager<Usuarios> signInManagerr,
        RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManagerr;
            this.roleManager = roleManager;

        }
		public async Task<IdentityResult> AddUserAsync(Usuarios user, string password)
		{
			return await this.userManager.CreateAsync(user, password);
		}

		public async Task AddUserToRoleAsync(Usuarios user, string roleName)
		{
			await this.userManager.AddToRoleAsync(user, roleName);
		}

		public async Task<IdentityResult> ChangePasswordAsync(Usuarios user, string oldPassword, string newPassword)
		{
			return await this.userManager.ChangePasswordAsync(user, oldPassword, newPassword);

		}

		public async Task CheckRoleAsync(string roleName)
		{


			var roleExists = await this.roleManager.RoleExistsAsync(roleName);
			if (!roleExists)
			{
				await this.roleManager.CreateAsync(new IdentityRole
				{
					Name = roleName
				});
			}


		}

		public async Task<Usuarios> GetUserByEmailAsync(string email)
		{
			return await this.userManager.FindByEmailAsync(email);

		}

		public async Task<bool> IsUserInRoleAsync(Usuarios user, string roleName)
		{
			return await this.userManager.IsInRoleAsync(user, roleName);
		}


		public async Task<SignInResult> LoginAsync(Login model)
		{
			return await this.signInManager.PasswordSignInAsync(
				model.Username,
				model.Contraseña,
				model.Recuerdame,
				false);
		}


		public async Task LogoutAsync()
		{
			await this.signInManager.SignOutAsync();
		}

		public async Task<IdentityResult> UpdateUserAsync(Usuarios user)
		{
			return await this.userManager.UpdateAsync(user);

		}

		public async Task<SignInResult> ValidatePasswordAsync(Usuarios user, string password)
		{
			return await this.signInManager.CheckPasswordSignInAsync(
			user,
			password,
			false);
		}
		public async Task<IdentityResult> ConfirmEmailAsync(Usuarios user, string token)
		{
			return await this.userManager.ConfirmEmailAsync(user, token);
		}

		public async Task<string> GenerateEmailConfirmationTokenAsync(Usuarios user)
		{
			return await this.userManager.GenerateEmailConfirmationTokenAsync(user);
		}

		public async Task<Usuarios> GetUserByIdAsync(string userId)
		{
			return await this.userManager.FindByIdAsync(userId);
		}
		public async Task<string> GeneratePasswordResetTokenAsync(Usuarios user)
		{
			return await this.userManager.GeneratePasswordResetTokenAsync(user);
		}

		public async Task<IdentityResult> ResetPasswordAsync(Usuarios user, string token, string password)
		{
			return await this.userManager.ResetPasswordAsync(user, token, password);
		}



	}
}
