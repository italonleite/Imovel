using Imovel.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imovel.API.Controllers.Models.Commands
{
    public class CreateImmobileCommand
    {
        public ImmobileType ImmobileType { get; set; }
        public Address Address { get; set; }
    }
}
