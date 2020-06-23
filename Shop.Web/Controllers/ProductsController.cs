using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Shop.Web.Data;
using Shop.Web.Data.Entities;
using Ventas.Web.Data.Entities;
using Ventas.Web.Models;

namespace Ventas.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IRepositorioProduct repositorioProducto;

        private readonly IUsuariosAyuda usuariosAyuda;

        public ProductsController(IRepositorioProduct repositorioProducto, IUsuariosAyuda usuariosAyuda)
        {
            this.repositorioProducto = repositorioProducto;
            this.usuariosAyuda = usuariosAyuda;
        }

        // GET: Products
        public IActionResult Index()
        {
            return View(this.repositorioProducto.GetAll().OrderBy(p => p.Nombre));
        }


        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)

            {
                
                return new NotFoundViewResult("ProductNotFound");
            }

            var product = await this.repositorioProducto.GetByIdAsync(id.Value);
            if (product == null)
            {
                return new NotFoundViewResult("ProductNotFound");
            }

            return View(product);
        }

        // GET: Products/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductModel view)
        {
            if (ModelState.IsValid)
            {
                //path es la ruta donde se guarda a foto
                var path = string.Empty;
                //ImageFile es el archivo ..la imagen.. en memoria
                if (view.ImageFile != null && view.ImageFile.Length > 0)
                {
                    var guid = Guid.NewGuid().ToString();
                    var file = $"{guid}.jpg";

                    path = Path.Combine
                        (Directory.GetCurrentDirectory(),
                        "wwwroot\\images\\Products",
                        file);
                    //con el siguiente codigo se sube las imagenes
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await view.ImageFile.CopyToAsync(stream);
                    }
                    //~ significa la ruta relativa ,no sabmos donde se publicca
                    path = $"~/images/Products/{file}";
                }

                var product = this.ToProduct(view, path);


                product.Usuarios = await this.usuariosAyuda.GetUserByEmailAsync(this.User.Identity.Name);
                await this.repositorioProducto.CreateAsync(product);
                return RedirectToAction(nameof(Index));
            }

            return View(view);
        }
        private Product ToProduct(ProductModel view, string path)
        {
            return new Product
            {
                Id = view.Id,
                ImageUrl = path,
                Disponible = view.Disponible,
                UltimaCompra = view.UltimaCompra,
                UltimaVenta = view.UltimaVenta,
                Nombre = view.Nombre,
                Precio = view.Precio,
                Stock = view.Stock,
                Usuarios = view.Usuarios

            };

        }
        // GET: Products/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return ProductNotEdit();
            }

            var product = await this.repositorioProducto.GetByIdAsync(id.Value);
            if (product == null)
            {
                return ProductNotEdit();
            }
            var view = this.ToPoductViewModel(product);
            return View(view);
        }
        private ProductModel ToPoductViewModel(Product product)

        {
            return new ProductModel
            {
                Id = product.Id,
                Disponible = product.Disponible,
                UltimaCompra = product.UltimaCompra,
                UltimaVenta = product.UltimaVenta,
                ImageUrl = product.ImageUrl,
                Nombre = product.Nombre,
                Precio = product.Precio,
                Stock = product.Stock,
                Usuarios = product.Usuarios



            };
        }
        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProductModel view)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var path = view.ImageUrl;
                    if (view.ImageFile != null && view.ImageFile.Length > 0)
                    {

                        var guid = Guid.NewGuid().ToString();
                        var file = $"{guid}.jpg";

                        path = Path.Combine
                            (Directory.GetCurrentDirectory(),
                            "wwwroot\\images\\Products",
                            file);
                        //con el siguiente codigo se sube las imagenes
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await view.ImageFile.CopyToAsync(stream);
                        }
                        //~ significa la ruta relativa ,no sabmos donde se publicca
                        path = $"~/images/Products/{file}";
                    }
                    var product = this.ToProduct(view, path);

                    product.Usuarios = await this.usuariosAyuda.GetUserByEmailAsync(this.User.Identity.Name);
                    await this.repositorioProducto.UpdateAsync(product);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await this.repositorioProducto.ExistAsync(view.Id))
                    {
                        return ProductNotEdit();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            return View(view);
        }

        // GET: Products/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return ProductNotDelete();
            }

            var product = await this.repositorioProducto.GetByIdAsync(id.Value);
            if (product == null)
            {
                return ProductNotDelete();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await this.repositorioProducto.GetByIdAsync(id);
            await this.repositorioProducto.DeleteAsync(product);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult ProductNotFound()
        {
            return this.View();
        }
        public IActionResult ProductNotEdit()
        {
            return this.View();
        }
        public IActionResult ProductNotDelete()
        {
            return this.View();
        }
    }
}
