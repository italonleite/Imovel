using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imovel.Domain.Models
{
    public class Immobile
    {
        public Guid ImmobileId { get; set; }
        public ImmobileType ImmobileType { get; set; }

        public Immobile(ImmobileType immobileType)
        {
            
            ImmobileId = Guid.NewGuid();
            ImmobileType = immobileType;
            Validar(immobileType);
        }

        private void Validar(ImmobileType immobileType)
        {
            if (immobileType == ImmobileType.UNDEFINED) throw new Exception("Deve ser definido um tipo de imóvel");
        }
    }
}
