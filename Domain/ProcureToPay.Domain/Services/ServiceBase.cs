using ProcureToPay.Domain.Interfaces.Repository;
using ProcureToPay.Domain.Interfaces.Services;


namespace ProcureToPay.Domain.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        private readonly IRepositoryBase<T> repository;

        public ServiceBase(IRepositoryBase<T> repository)
        {
            this.repository = repository;
        }

        public async Task Atualizar(T entity)
        {
            await repository.Atualizar(entity);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Excluir(int id)
        {
            return await repository.Excluir(id);
        }

        public async Task Inserir(T entity)
        {
            await repository.Inserir(entity);
        }

        public async Task<T> ListarPorId(int id)
        {
            return await repository.ListarPorId(id);
        }

        public async Task<IEnumerable<T>> ListarTodos()
        {
            return await repository.ListarTodos();
        }
    }
}
