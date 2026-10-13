using ProcureToPay.Domain.Entities;
using ProcureToPay.Domain.Interfaces.Repository;
using ProcureToPay.Infra.Data.Context;


namespace ProcureToPay.Infra.Data.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        private readonly ProcureToPayContext _context;
        public UsuarioRepository(ProcureToPayContext context) : base(context)
        {
            _context = context;
        }
    }
}
