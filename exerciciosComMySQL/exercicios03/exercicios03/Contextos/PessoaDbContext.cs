using exercicios03.Entidades;
using Microsoft.EntityFrameworkCore;

namespace exercicios03.Contextos
{
    public class PessoaDbContext:DbContext
    {
        public PessoaDbContext(DbContextOptions<PessoaDbContext> options):base(options) { }

        public DbSet<Pessoa> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define a propriedade 'Codigo' como chave primária da entidade 'Pessoa'
            modelBuilder.Entity<Pessoa>().HasKey(i => i.Codigo);
        }

    }
}
