﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ventas.Web.Models
{
    public class RegistrarNuevoUsuario
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Apellido Paterno")]
        public string ApellidoPaterno { get; set; }

        [Required]
        [Display(Name = "Apellido Materno")]
        public string ApellidoMaterno { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Username { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }



        [MaxLength(100, ErrorMessage = "El valor {0} no es valido {1} characters length.")]
        [Display(Name = "Direccion")]
        public string Direccion { get; set; }

       /* [MaxLength(100, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        [Display(Name = "Correo")]
        public string Correo { get; set; }
       */

        [MaxLength(20, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        [Display(Name = "PhoneNumber")]
        public string PhoneNumber { get; set; }
    }
}

