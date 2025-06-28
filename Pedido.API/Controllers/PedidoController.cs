using Microsoft.AspNetCore.Mvc;
using Pedidos.API.Models;
using Pedidos.API.Services;

namespace Pedidos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidoController(PedidoService pedidoService) : ControllerBase
    {

        [HttpGet("{id}")]
        public Pedido GetById(Guid id)
        {
            return pedidoService.GetById(id);
        }

        [HttpGet]
        public List<Pedido> GetAll()
        {
            return pedidoService.GetAll();
        }

        [HttpPost]
        public Pedido Add(Pedido pedido)
        {
            return pedidoService.Add(pedido);
        }
    }
}
