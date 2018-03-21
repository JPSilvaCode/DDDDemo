using DDDDemo.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace DDDDemo.Infraestrutura.Dados.Contexto.Mapping
{
    public class CategoriaMap : EntityTypeConfiguration<Categoria>
    {
        public CategoriaMap()
        {
            // Primary Key
            HasKey(c => c.CategoriaId);

            // Properties
            Property(p => p.Nome)
                .HasMaxLength(120)
                .IsRequired();
        }
    }
}
