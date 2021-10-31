using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imovel.Domain.Shared.Repositories
{
    public interface IRepository<TEntity>
    {
        void Insert(TEntity entity);
        List<TEntity> Get();
    }
}
