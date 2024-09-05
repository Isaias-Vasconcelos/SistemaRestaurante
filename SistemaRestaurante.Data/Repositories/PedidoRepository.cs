using SistemaRestaurante.Data.Database;
using SistemaRestaurante.Domain.Entidades;
using SistemaRestaurante.Domain.Interfaces;

namespace SistemaRestaurante.Data.Repositories
{
    public class PedidoRepository : Repository<Pedido>, IPedidoRepository
    {
        public PedidoRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
