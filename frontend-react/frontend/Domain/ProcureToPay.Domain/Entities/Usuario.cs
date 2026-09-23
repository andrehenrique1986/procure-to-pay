namespace ProcureToPay.Domain.Entities
{
    public class Usuario
    {
        public int UsuarioId { get; private set; }
        public string UsuarioNome { get; private set; }
        public string UsuarioEmail { get; private set; }
        public string UsuarioCPF { get; private set; }
        public string UsuarioSenhaHash { get; private set; }

    }
}
