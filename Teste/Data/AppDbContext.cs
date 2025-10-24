using Microsoft.EntityFrameworkCore;
using Moveis_Carrara.Models;

namespace Moveis_Carrara.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Pessoa)
                .WithMany()
                .HasForeignKey(u => u.PessoaCodigo);
        }
    }
}
