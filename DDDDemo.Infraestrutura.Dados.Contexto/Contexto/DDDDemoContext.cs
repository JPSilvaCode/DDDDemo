using DDDDemo.Dominio.Entidades;
using DDDDemo.Infraestrutura.Dados.Contexto.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDDemo.Infraestrutura.Dados.Contexto.Contexto
{
    public class DDDDemoContext : DbContext
    {
        public DDDDemoContext()
            : base("DefaultConnection")
        {

        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new CategoriaMap());
            modelBuilder.Configurations.Add(new ProdutoMap());

            base.OnModelCreating(modelBuilder);
        }      
    }
}
