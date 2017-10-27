using ListaDeFilmes.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ListaDeFilmes.Data.EF.Maps
{
    class DiretorMap : EntityTypeConfiguration<Diretor>
    {
        public DiretorMap()
        {
            //Tabela
            ToTable("Diretor");

            //ToTable(nameof(Cliente)); c#6

            //PK
            HasKey(pk => pk.Id);

            //HasKey(pk=> new(pk.Id, pk.Nome)); PK COMPOSTA

            //Colunas
            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Nome).HasColumnType("varchar").HasMaxLength(150).IsRequired();

        }
    }
}
