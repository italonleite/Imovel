using Imovel.Domain.Interfaces;
using Imovel.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imovel.Domain.Services.ImmobileService
{
    public class ImmobileService
    {
        private readonly IImmobileRepository _immobileRepository;

        public ImmobileService(IImmobileRepository immobileRepository)
        {
            _immobileRepository = immobileRepository;
        }

        public void ValidateImmobile(Immobile immobile)
        {
            immobile.ValidateImmobile(immobile);              
        }

        public void Insert(Immobile immobile)
        {
            _immobileRepository.Insert(immobile);
        }

        public IEnumerable<Immobile> Get()
        {
            return _immobileRepository.Get();
        }
    }
}
