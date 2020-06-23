
namespace Ventas.Web.Controllers.API
{
    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Shop.Web.Data;
    using Ventas.Web.Data.Entities;

    [Route("api/[Controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    public class ProductsController : Controller
    {
        private readonly IRepositorioPedido productRepository;

        public ProductsController(IRepositorioPedido productRepository)
        {
            this.productRepository = productRepository;
        }/*
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(this.productRepository.GetAllWithUsers());
        }*/

    }
}
