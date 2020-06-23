using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Ventas.Web.Data.Entities;

namespace Shop.Web.Data.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }


        [MaxLength(50, ErrorMessage = "The field {0} only can contain  ")]//para que no exeda las 50 letras 
        [Required]
       public string Nombre { get; set; }

      
        [DisplayFormat(DataFormatString ="{0:C2}",ApplyFormatInEditMode = false)]
        public decimal Precio { get; set; }

        
        [Display(Name ="Image")]
        public string ImageUrl { get; set; }
        
        [Display(Name = "Ultima Compra")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public string UltimaCompra { get; set; }

        [Display(Name = "Ultima Venta")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public string UltimaVenta { get; set; }
        
        [Display(Name = "Disponible")]
        public bool Disponible { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]

        public double Stock { get; set; }

        public Usuarios Usuarios { get; set; }


        public string ImageFullPath
        {
            get
            {
                if (String.IsNullOrEmpty(this.ImageUrl))
                {
                    return null;
                }
                //LA RUTA DE NUESTRO PROYECTO 
                //https://localhost:44319/Products
                return $"https://shopnany.azurewebsites.net{this.ImageUrl.Substring(1)}";
            }
        }

    }

}
