using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Shop.Web.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        /// <summary>
        /// antes de la tragedia
        /// </summary>
        public string Nombre { get; set; }

        [DisplayFormat(DataFormatString ="{0:C2}",ApplyFormatInEditMode = false)]
        public decimal Precio { get; set; }
        
        [Display(Name ="Image")]
        public string ImageUrl { get; set; }
        
        [Display(Name = "Ultima Compra")]
        public string UltimaCompra { get; set; }

        [Display(Name = "Ultima Venta")]
        public string UltimaVenta { get; set; }
        
        [Display(Name = "Disponible")]
        public string Disponible { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]

        public double Stock { get; set; }
    }

}
