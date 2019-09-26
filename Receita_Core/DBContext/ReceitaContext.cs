using ApiReceita.Model;
using Microsoft.EntityFrameworkCore;


namespace ReceitaCore.Context
{
   public class ReceitaContext : DbContext
    {
        public ReceitaContext(DbContextOptions<ReceitaContext>options):base(options)
        { }


        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Papel> Papel { get; set; }
        public DbSet<Receita> Receita { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<UsuarioAdm> UsuarioAdm { get; set; }

    }
}
