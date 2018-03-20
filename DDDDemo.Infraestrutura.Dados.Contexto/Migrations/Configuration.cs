namespace DDDDemo.Infraestrutura.Dados.Contexto.Migrations
{
    using DDDDemo.Infraestrutura.Dados.Contexto.Contexto;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DDDDemoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DDDDemo.Infraestrutura.Dados.Contexto.Contexto.DDDDemoContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
