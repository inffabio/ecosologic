namespace Ecosologic.UI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Ecosologic.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Ecosologic.UI.EcoSolContexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Ecosologic.UI.EcoSolContexto context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.UFS.Add(new UF { Sigla = "AC", Descricao = "Acre" });
            context.UFS.Add(new UF { Sigla = "AL", Descricao = "Alagoas" });
            context.UFS.Add(new UF { Sigla = "AP", Descricao = "Amapá" });
            context.UFS.Add(new UF { Sigla = "AM", Descricao = "Amazonas" });
            context.UFS.Add(new UF { Sigla = "BA", Descricao = "Bahia" });
            context.UFS.Add(new UF { Sigla = "CE", Descricao = "Ceará" });
            context.UFS.Add(new UF { Sigla = "DF", Descricao = "Distrito Federal" });
            context.UFS.Add(new UF { Sigla = "ES", Descricao = "Espirito Santo" });
            context.UFS.Add(new UF { Sigla = "GO", Descricao = "Goiás" });
            context.UFS.Add(new UF { Sigla = "MA", Descricao = "Maranhão" });
            context.UFS.Add(new UF { Sigla = "MS", Descricao = "Mato Grosso do Sul" });
            context.UFS.Add(new UF { Sigla = "MT", Descricao = "Mato Grosso" });
            context.UFS.Add(new UF { Sigla = "MG", Descricao = "Minas Gerais" });
            context.UFS.Add(new UF { Sigla = "PA", Descricao = "Pará" });
            context.UFS.Add(new UF { Sigla = "PB", Descricao = "Paraíba" });
            context.UFS.Add(new UF { Sigla = "PR", Descricao = "Paraná" });
            context.UFS.Add(new UF { Sigla = "PE", Descricao = "Pernambuco" });
            context.UFS.Add(new UF { Sigla = "PI", Descricao = "Piauí" });
            context.UFS.Add(new UF { Sigla = "RJ", Descricao = "Rio de Janeiro" });
            context.UFS.Add(new UF { Sigla = "RN", Descricao = "Rio Grande do Norte" });
            context.UFS.Add(new UF { Sigla = "RS", Descricao = "Rio Grande do Sul" });
            context.UFS.Add(new UF { Sigla = "RO", Descricao = "Rondônia" });
            context.UFS.Add(new UF { Sigla = "RR", Descricao = "Roraima" });
            context.UFS.Add(new UF { Sigla = "SC", Descricao = "Santa Catarina" });
            context.UFS.Add(new UF { Sigla = "SP", Descricao = "São Paulo" });
            context.UFS.Add(new UF { Sigla = "SE", Descricao = "Sergipe" });
            context.UFS.Add(new UF { Sigla = "TO", Descricao = "Tocantins" });

        }
    }
}
