using SistemaRestaurante.Data.Database;
using SistemaRestaurante.Domain.Entidades;
using SistemaRestaurante.Domain.Interfaces;

namespace SistemaRestaurante.Data.Repositories
{
    public class RestauranteRepository : Repository<Restaurante>, IRestauranteRepository
    {
        public RestauranteRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
