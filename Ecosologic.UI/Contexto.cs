using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using Ecosologic.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Ecosologic.UI
{
    public class EcoSolContexto: DbContext
    {
        public EcoSolContexto(): base("ConexaoBDEcosologic")
        {
            Database.CreateIfNotExists();
        }

        public virtual DbSet<PedidoOrcamento> PedidosOrcamento { get; set; }
        public virtual DbSet<UF> UFS { get; set; }

        protected override void OnModelCreating(DbModelBuilder _modelBuilder)
        {
            _modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            _modelBuilder.Properties<Decimal>().Configure(prop => prop.HasPrecision(5, 2));
            _modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>(); 

            base.OnModelCreating(_modelBuilder);
        }
 
    }
}