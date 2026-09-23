using Microsoft.EntityFrameworkCore;
using ProcureToPay.Domain.Interfaces.Repository;
using ProcureToPay.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcureToPay.Infra.Data.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly ProcureToPayContext _context;

        public RepositoryBase(ProcureToPayContext context)
        {
            _context = context;
        }

        public async Task Atualizar(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
            return;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Excluir(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            if (entity == null)
            {
                return false;
            }
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task Inserir(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
            return;
        }

        public async Task<T> ListarPorId(int id)
        {
            _context.Set<T>().Find(id);
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> ListarTodos()
        {
            return await _context.Set<T>().ToListAsync();
        }
    }
}
