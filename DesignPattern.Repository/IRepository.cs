using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Repository
{
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> Get();

        TEntity Get(int id);

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        void Save();
    }
}
