using ProcureToPay.Domain.Entities;
using ProcureToPay.Domain.Interfaces.Repository;
using ProcureToPay.Domain.Interfaces.Services;


namespace ProcureToPay.Domain.Services
{
    public class UsuarioService : ServiceBase<Usuario>, IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository): 
            base(usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
    }
}
