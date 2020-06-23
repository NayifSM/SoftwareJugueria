using Shop.Web.Data.Entities;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ventas.Web.Models;

namespace Ventas.Web.Data.Entities
{

    //username=nombre
    public interface IRepositorioPedido : IRepositorioGenerico<Pedido>
    {
		Task<IQueryable<Pedido>> GetOrdersAsync(string userName);

		Task<IQueryable<DetallesPedidoTemporal>> GetDetailTempsAsync(string userName);

		Task AddItemToOrderAsync(AgregarElemento model, string userName);

		Task ModifyOrderDetailTempQuantityAsync(int id, double quantity);

		Task DeleteDetailTempAsync(int id);

		Task<bool> ConfirmOrderAsync(string userName);
		Task DeliverOrder(Delivery model);

		Task<Pedido> GetOrdersAsync(int id);

	}

}
