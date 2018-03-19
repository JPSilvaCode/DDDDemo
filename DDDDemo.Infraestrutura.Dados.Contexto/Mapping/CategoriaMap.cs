using DDDDemo.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
