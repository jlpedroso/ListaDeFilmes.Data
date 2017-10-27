using ListaDeFilmes.Domain.Entities;
using System.Collections.Generic;
using System.Data.Entity;

namespace ListaDeFilmes.Data.EF
{
    internal class DbInitializer : CreateDatabaseIfNotExists<FilmesDataContext>
    {
        protected override void Seed(FilmesDataContext context)
        {
            context.Diretores.AddRange(
                new List<Diretor> { 
                    new Diretor{
                        Nome="Christopher Nolan"
                    },
                    new Diretor{
                        Nome="Woody Allen"}
                }
                );

            //context.Usuarios.AddRange(
            //    new List<Usuario> { 
            //        new Usuario {Email="jlpedroso@yahoo.com.br", Senha="123456".Encrypt()},    
            //        new Usuario {Email="jlpedroso@gmail.com", Senha="654321".Encrypt()},    
            //        new Usuario {Email="jlpedroso@bol.com.br", Senha="123457".Encrypt()}
            //    }
            //    );

            context.SaveChanges();
        }
    }
}
