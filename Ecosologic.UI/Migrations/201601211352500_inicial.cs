namespace Ecosologic.UI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PedidoOrcamento",
                c => new
                    {
                        PedidoOrcamentoId = c.Long(nullable: false, identity: true),
                        Nome = c.String(),
                        Email = c.String(),
                        Telefone = c.String(),
                        Celular = c.String(),
                        Cidade = c.String(),
                        Estado = c.String(),
                        MediaContaLuz = c.String(),
                        Duvidas = c.String(),
                        DataPedido = c.DateTime(),
                    })
                .PrimaryKey(t => t.PedidoOrcamentoId);
            
            CreateTable(
                "dbo.UF",
                c => new
                    {
                        UFId = c.Long(nullable: false, identity: true),
                        Sigla = c.String(),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.UFId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UF");
            DropTable("dbo.PedidoOrcamento");
        }
    }
}
