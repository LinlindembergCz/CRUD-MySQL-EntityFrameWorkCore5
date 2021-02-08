using Microsoft.EntityFrameworkCore;
using meuprojeto.Models;

namespace meuprojeto.Database
{
    public class ApplicationDBContext : DbContext
    {
        
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public DbSet<Funcionario> Funcionarios { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
         //   optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Funcionario>().Property<byte[]>()
            base.OnModelCreating(modelBuilder);
        }
    }
}