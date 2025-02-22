using DesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.RepositoryPattern
{
    public interface IBeerRepository
    {
        IEnumerable<Beer> Get();

        Beer Get(int id);

        void Add(Beer beer);

        void Update(Beer beer);

        void Delete(int id);

        void Save();
    }
}
