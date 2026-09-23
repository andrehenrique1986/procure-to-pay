using ProcureToPay.Domain.Entities;
using ProcureToPay.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcureToPay.Infra.Data.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>
    {
        private readonly ProcureToPayContext _context;
        public UsuarioRepository(ProcureToPayContext context) : base(context)
        {
            _context = context;
        }
    }
}
