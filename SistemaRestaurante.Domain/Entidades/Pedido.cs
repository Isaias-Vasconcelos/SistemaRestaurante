using SistemaRestaurante.Domain.Entidades.Base;
using SistemaRestaurante.Domain.Enum;

namespace SistemaRestaurante.Domain.Entidades
{
    public class Pedido:EntidadeBase
    {
        public string? Titulo { get;private set; }
        public string? Descricao { get;private set; }
        public StatusPedidoEnum Status { get;private set; }
        public Guid RestauranteId { get;private set; }
        public Restaurante? Restaurante { get; set; }    
        private Pedido()
        {

        }
        public Pedido(Guid id, string? titulo, string? descricao ,Guid restauranteId, StatusPedidoEnum status)
        {
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
            RestauranteId = restauranteId;
            Status = status;
        }
        public Pedido(string titulo, string descricao, Guid restauranteId)
        {
            Id = Guid.NewGuid();
            Titulo = titulo;
            Descricao = descricao;
            RestauranteId = restauranteId;
            Status = StatusPedidoEnum.CRIADO;
        }

        public bool ValidateLenghtDesc()
        {
            if(Descricao?.Length < 10)
                return false;

            return true;
        }
    }
}
