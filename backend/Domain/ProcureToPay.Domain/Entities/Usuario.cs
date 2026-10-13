namespace ProcureToPay.Domain.Entities
{
    public class Usuario
    {
        public int UsuarioId { get; private set; }
        public string UsuarioNome { get; private set; }
        public string UsuarioEmail { get; private set; }
        public string UsuarioCPF { get; private set; }
        public string UsuarioSenhaHash { get; private set; }
        public bool UsuarioAtivo { get; private set; }
        public DateTime UsuarioDataCriao { get; private set; }


        private Usuario() { } // Construtor privado para EF Core

        public Usuario(
           int usuarioId, 
           string usuarioNome, 
           string usuarioEmail, 
           string usuarioCPF, 
           string usuarioSenhaHash, 
           bool usuarioAtivo, 
           DateTime usuarioDataCriao
            )
        {
            UsuarioId = usuarioId;
            ValidateDomain(
                usuarioNome, 
                usuarioEmail, 
                usuarioCPF, 
                usuarioSenhaHash, 
                usuarioAtivo, 
                usuarioDataCriao);
        }

        public Usuario(
            string usuarioNome, 
            string usuarioEmail, 
            string usuarioCPF, 
            string usuarioSenhaHash, 
            bool usuarioAtivo, 
            DateTime usuarioDataCriao
            )
        {
            ValidateDomain(
                usuarioNome, 
                usuarioEmail, 
                usuarioCPF, 
                usuarioSenhaHash, 
                usuarioAtivo, 
                usuarioDataCriao);
        }

        public void ValidateDomain(
            string usuarioNome,
            string usuarioEmail,
            string usuarioCPF,
            string usuarioSenhaHash,
            bool usuarioAtivo,
            DateTime usuarioDataCriao
            )
        {
            UsuarioNome = usuarioNome;
            UsuarioEmail = usuarioEmail;
            UsuarioCPF = usuarioCPF;
            UsuarioSenhaHash = usuarioSenhaHash;
            UsuarioAtivo = usuarioAtivo;
            UsuarioDataCriao = usuarioDataCriao;
        }
    }
}
