using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Ecosologic.Models
{
    [Table("UF")]
    public class UF
    {
        public long UFId { get; set; }
        public String Sigla  { get; set; }
        public String Descricao { get; set; }
        

    }
}