using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcureToPay.Application.AppServices.Interfaces
{
    public interface IAppServiceBase<T> : IDisposable where T : class
    {
        Task Inserir(T entity);
        Task<IEnumerable<T>> ListarTodos();
        Task<T> ListarPorId(int id);
        Task Atualizar(T entity);
        Task<bool> Excluir(int id);
    }
}
