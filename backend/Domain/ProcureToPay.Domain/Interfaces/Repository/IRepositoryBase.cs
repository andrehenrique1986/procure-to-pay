namespace ProcureToPay.Domain.Interfaces.Repository
{
    public interface IRepositoryBase<T> : IDisposable where T : class
    {
        Task Inserir(T entity);
        Task<IEnumerable<T>> ListarTodos();
        Task<T> ListarPorId(int id);
        Task Atualizar(T entity);
        Task<bool> Excluir(int id);
    }
}
