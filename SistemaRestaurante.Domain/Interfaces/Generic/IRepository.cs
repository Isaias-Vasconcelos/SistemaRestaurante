namespace SistemaRestaurante.Domain.Interfaces.Generic
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
