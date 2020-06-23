using Microsoft.EntityFrameworkCore;
using Shop.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ventas.Web.Models;

namespace Ventas.Web.Data.Entities
{
    public class RepositorioPedidos : RepositorioGenerico<Pedido>, IRepositorioPedido
    {

        private readonly DataContext context;
        private readonly IUsuariosAyuda usuariosAyuda;

        public RepositorioPedidos(DataContext context, IUsuariosAyuda usuariosAyuda) : base(context)
        {
            this.context = context;
            this.usuariosAyuda = usuariosAyuda;
        }
        public async Task<IQueryable<Pedido>> GetOrdersAsync(string userName)
        {
            var user = await this.usuariosAyuda.GetUserByEmailAsync(userName);
            if (user == null)
            {
                return null;
            }

            if (await this.usuariosAyuda.IsUserInRoleAsync(user, "Admin"))
            {
                return this.context.Pedido
                    .Include(o => o.Usuarios)
                    .Include(o => o.Items)
                    .ThenInclude(i => i.Product)
                    .OrderByDescending(o => o.OrdenFecha);
            }

            return this.context.Pedido

                .Include(o => o.Items)
                .ThenInclude(i => i.Product)
                .Where(o => o.Usuarios == user)
                .OrderByDescending(o => o.OrdenFecha);


        }
        public async Task<IQueryable<DetallesPedidoTemporal>> GetDetailTempsAsync(string userName)
        {
            var user = await this.usuariosAyuda.GetUserByEmailAsync(userName);
            if (user == null)
            {
                return null;
            }

            return this.context.DetallesPedidoTemporal
                .Include(o => o.Product)
                .Where(o => o.User == user)
                .OrderBy(o => o.Product.Nombre);

        }
        public async Task AddItemToOrderAsync(AgregarElemento model, string userName)
        {
            var user = await this.usuariosAyuda.GetUserByEmailAsync(userName);
            if (user == null)
            {
                return;
            }

            var product = await this.context.Products.FindAsync(model.ProductId);
            if (product == null)
            {
                return;
            }

            var orderDetailTemp = await this.context.DetallesPedidoTemporal
                .Where(odt => odt.User == user && odt.Product == product)
                .FirstOrDefaultAsync();
            if (orderDetailTemp == null)
            {
                orderDetailTemp = new DetallesPedidoTemporal
                {
                    Precio = product.Precio,
                    Product = product,
                    Cantidad = model.Cantidad,
                    User = user,
                };

                this.context.DetallesPedidoTemporal.Add(orderDetailTemp);

            }
            else
            {
                orderDetailTemp.Cantidad += model.Cantidad;
                this.context.DetallesPedidoTemporal.Update(orderDetailTemp);
            }

            await this.context.SaveChangesAsync();
        }
        public async Task ModifyOrderDetailTempQuantityAsync(int id, double quantity)
        {
            var DetallesPedidoTemporal = await this.context.DetallesPedidoTemporal.FindAsync(id);
            if (DetallesPedidoTemporal == null)
            {
                return;
            }

            DetallesPedidoTemporal.Cantidad += quantity;
            if (DetallesPedidoTemporal.Cantidad > 0)
            {
                this.context.DetallesPedidoTemporal.Update(DetallesPedidoTemporal);
                await this.context.SaveChangesAsync();
            }
        }
        public async Task DeleteDetailTempAsync(int id)
        {
            var DetallesPedidoTemporal = await this.context.DetallesPedidoTemporal.FindAsync(id);
            if (DetallesPedidoTemporal == null)
            {
                return;
            }

            this.context.DetallesPedidoTemporal.Remove(DetallesPedidoTemporal);
            await this.context.SaveChangesAsync();
        }
        public async Task<bool> ConfirmOrderAsync(string userName)
        {/*
            var user = await this.userHelper.GetUserByEmailAsync(userName);
            if (user == null)
            {
                return false;
            }*/



            var orderTmps = await this.context.DetallesPedidoTemporal
                .Include(o => o.Product)
                .ToListAsync();

            if (orderTmps == null || orderTmps.Count == 0)
            {
                return false;
            }

            var details = orderTmps.Select(o => new DetallesPedido
            {
                Precio = o.Precio,
                Product = o.Product,
                Cantidad = o.Cantidad
            }).ToList();

            var order = new Pedido
            {
                OrdenFecha = DateTime.UtcNow,
                Items = details,
            };

            this.context.Pedido.Add(order);
            this.context.DetallesPedidoTemporal.RemoveRange(orderTmps);
            await this.context.SaveChangesAsync();
            return true;
        }
        public async Task DeliverOrder(Delivery model)
        {
            var order = await this.context.Pedido.FindAsync(model.Id);
            if (order == null)
            {
                return;
            }

            order.DeliveryFecha = model.DeliveryFecha;
            this.context.Pedido.Update(order);
            await this.context.SaveChangesAsync();
        }
        public async Task<Pedido> GetOrdersAsync(int id)
        {
            return await this.context.Pedido.FindAsync(id);
        }
    }
}
