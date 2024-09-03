using SistemaRestaurante.Domain.Entidades.Base;
using SistemaRestaurante.Domain.Enum;

namespace SistemaRestaurante.Domain.Entidades
{
    public class Pedido:EntidadeBase
    {
        public string? Titulo { get;private set; }
        public string? Descricao { get;private set; }
        public StatusPedidoEnum Status { get;private set; }

        private Pedido()
        {

        }
        public Pedido(Guid id, string? titulo, string? descricao , StatusPedidoEnum status)
        {
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
            Status = status;
        }
        public Pedido(string titulo, string descricao)
        {
            Id = Guid.NewGuid();
            Titulo = titulo;
            Descricao = descricao;
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
