using Imovel.Data.Context;
using Imovel.Domain.Interfaces;
using Imovel.Domain.Models;
using Imovel.Domain.Shared.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imovel.Data.Repositories
{
    public class ImmobileRepository : IImmobileRepository
    {
        protected readonly ImmobileDbContext dbContext;
        public ImmobileRepository(ImmobileDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Immobile> Get()
        {
            return dbContext.Immobiles.Include(x => x.Address).ToList();
        }

        public void Insert(Immobile entity)
        {
             dbContext.Immobiles.Add(entity);
             dbContext.SaveChanges();
           
        }

        
    }
}
