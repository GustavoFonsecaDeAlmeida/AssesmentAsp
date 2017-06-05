using AT_AspNet.Domain;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AT_AspNet.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")

           
        {

        }
        public DbSet<Autor> Autores { get; set; }

        public DbSet<Livro> Livros { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
