using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD

=======
using ProcureToPay.Domain.Entities;
>>>>>>> 83c4645 (Criando o Dockerfile)

namespace ProcureToPay.Infra.Data.Context
{
    public class ProcureToPayContext : DbContext
    {
<<<<<<< HEAD
        public ProcureToPayContext(DbContextOptions<ProcureToPayContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(ProcureToPayContext).Assembly);
=======
        public DbSet<Usuario> Usuario { get; set; }

        public ProcureToPayContext(DbContextOptions<ProcureToPayContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Registra automaticamente todas as classes que implementam IEntityTypeConfiguration<T>
            // no mesmo assembly onde esta o ProcureToPayDbContext
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(ProcureToPayContext).Assembly);
           

>>>>>>> 83c4645 (Criando o Dockerfile)
        }
    }
}
