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
        public Guid AddressId { get; set; }
        public Address Address { get; }

        public Immobile()
        {

        }
        public Immobile(ImmobileType immobileType, Address address)
        {
            
            ImmobileId = Guid.NewGuid();
            ImmobileType = immobileType;
            Address = new Address(address.AddressId, address.City, address.Complement, address.District, address.Number, address.State, address.State, address.Zip);             
        }

        public void ValidateImmobile(Immobile immobile)
        {
            if (immobile.Address is null) throw new Exception("Deve ser informado um endereço");
            if (immobile.ImmobileType == ImmobileType.UNDEFINED) throw new Exception("Deve ser informado um tipo de imóvel");            
        }               
    }
}
