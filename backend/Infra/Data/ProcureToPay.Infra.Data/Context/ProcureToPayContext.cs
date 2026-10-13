using Microsoft.EntityFrameworkCore;
using ProcureToPay.Domain.Entities;

namespace ProcureToPay.Infra.Data.Context
{
    public class ProcureToPayContext : DbContext
    {
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
           

        }
    }
}
