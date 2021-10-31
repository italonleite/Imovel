using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imovel.Domain.Models
{
    public enum ImmobileType
    {
        [Description("Indefinido")]
        UNDEFINED,

        [Description("Residencial")]
        RESIDENTIAL,

        [Description("Comercial")]
        COMMERCIAL

    }
}
