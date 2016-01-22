using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Ecosologic.Models
{
    public enum MediaContaLuz
    {
        [Description("Entre R$200 e R$300")]
        entre200e300 = 1,
        [Description("Entre R$300 e R$400")]
        entre300e400 = 2,
        [Description("Entre R$400 e R$500")]
        entre400e500 = 3,
        [Description("Entre R$500 e R$600")]
        entre500e600 = 4,
        [Description("Entre R$600 e R$700")]
        entre600e700 = 5,
        [Description("Entre R$700 e R$800")]
        entre700e800 = 6,
        [Description("Entre R$900 e R$1000")]
        entre900e1000 = 7,
        [Description("Acima de R$1000")]
        acima1000 = 8
    }
}