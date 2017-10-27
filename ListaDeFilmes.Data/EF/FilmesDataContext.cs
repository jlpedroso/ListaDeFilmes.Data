using ListaDeFilmes.Data.EF.Maps;
using ListaDeFilmes.Domain.Entities;
using System.Data.Entity;

namespace ListaDeFilmes.Data.EF
{
    public class FilmesDataContext: DbContext
    {
        public FilmesDataContext()
            : base("FilmesConn")
        {
            Database.SetInitializer(new DbInitializer());
   //         Configuration.LazyLoadingEnabled = false;  // PARA NÂO ENTRAR EM LOOP NA BUSCA COM INCLUDE // SE ALTERAR O WebApiConfig NÃO PRECISA
        }

        public DbSet<Diretor> Diretores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DiretorMap());
        }

    }
}
