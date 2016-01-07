using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Ecosologic.Models
{
    [Table("PedidoOrcamento")]
    public class PedidoOrcamento
    {
        public long PedidoOrcamentoId { get; set; }
        public String Nome  { get; set; }
        public String Email { get; set; }
        public String Telefone { get; set; }
        public String Celular { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }
        public String MediaContaLuz{ get; set; }
        public String Duvidas { get; set; }
        public DateTime? DataPedido { get; set; }
        [NotMapped]
        public List<UF> ListUF { get; set; }
        [NotMapped]
        public UF UFSelecionado { get; set; }

    }
}