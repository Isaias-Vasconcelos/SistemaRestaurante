using SistemaRestaurante.Domain.Entidades.Base;

namespace SistemaRestaurante.Domain.Entidades
{
    public class Restaurante:EntidadeBase
    {
        public string? Nome { get;private set; }
        private Restaurante() { }
        public Restaurante(string? nome)
        {
            Id = Guid.NewGuid();
            Nome = nome;
        }
    }
}
