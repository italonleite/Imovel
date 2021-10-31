using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imovel.Domain.Models
{
    public class Address
    {
        public Guid AddressId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Complement { get; set; }
        public string District { get; set; }
        public string Number { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public Address()
        {

        }
        public Address(Guid addressId, string street, string city, string complement, string district, string number, string state, string zip)
        {
            AddressId = SetNew(addressId);
            Street = street;
            City = city;
            Complement = complement;
            District = district;
            Number = number;
            State = state;
            Zip = zip;
        }



        public Guid SetNew(Guid? addressId)
        {
            if (addressId == Guid.Empty || addressId == null)
            {
                return AddressId = Guid.NewGuid();
            }
            return AddressId = (Guid)addressId;
        }

    }
}
