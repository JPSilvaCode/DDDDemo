using DDDDemo.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDDemo.Infraestrutura.Dados.Contexto.Mapping
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            // Primary Key
            HasKey(p => p.ProdutoId);

            // Properties
            Property(p => p.Nome)
                .HasMaxLength(120)
                .IsRequired();

            Property(p => p.Valor)
                .HasPrecision(18, 2)
                .IsRequired();

            Property(p => p.Situacao)                
                .IsRequired();

            // Relationship
            HasRequired(p => p.Categoria)
               .WithMany()
               .HasForeignKey(p => p.CategoriaId);
        }
    }
}
