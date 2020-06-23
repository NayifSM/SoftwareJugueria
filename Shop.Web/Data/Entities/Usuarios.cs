using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ventas.Web.Data.Entities
{
    public class Usuarios : IdentityUser
    {
        [MaxLength(50, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        public string Nombre { get; set; }

        [MaxLength(50, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        public string ApellidoPaterno { get; set; }

        [MaxLength(50, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        public string ApellidoMaterno { get; set; }
        

        [MaxLength(100, ErrorMessage = "El valor {0} no es valido {1} characters length.")]
        [Display(Name = "Direccion")]
        public string Direccion { get; set; }
        /*
        [MaxLength(100, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        [Display(Name = "Correo")]
        public string Correo { get; set; }
        
        [MaxLength(20, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        [Display(Name = "PhoneNumber")]
        public string PhoneNumber { get; set; }
        */
        [Display(Name = "Nombre Completo")]
        public string NombreCompleto { get { return $"{ this.Nombre}{ this.ApellidoPaterno}{ this.ApellidoMaterno} "; } }


    }
}