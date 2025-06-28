using Pedidos.API.Exceptions;
using Pedidos.API.Models;
using Pedidos.API.Persistence;

namespace Pedidos.API.Services
{
    public class PedidoService(PedidoRepository repository)
    {
        // Obter por id
        public Pedido GetById(Guid id)
        {
            var pedido = repository.GetById(id);

            if (pedido == null)
            {
                throw new NaoEncontradoException("Pedido não encontrado.");
            }

            return pedido;
        }

        // Obter todos
        public List<Pedido> GetAll()
        {
            return repository.GetAll();
        }

        // Adicionar
        public Pedido Add(Pedido pedido)
        {
            // 1. Verificar se pizza existe
            // 2. Salvar o pedido
            repository.Add(pedido);
            // 3. Atualiza o estoque
            // 4. Notificar o cliente

            return pedido;
        }


    }
}
