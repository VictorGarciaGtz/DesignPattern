using DesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.RepositoryPattern
{
    public class BeerRepository : IBeerRepository
    {
        private DesignPatternContext _context;

        public BeerRepository(DesignPatternContext context)
        {
            _context = context;
        }

        public void Add(Beer beer)
        {
            _context.Beers.Add(beer);
        }

        public void Delete(int id)
        {
            Beer beer = _context.Beers.Find(id);
            _context.Beers.Remove(beer);
        }

        public IEnumerable<Beer> Get()
        {
            return _context.Beers.ToList();
        }

        public Beer Get(int id)
        {
            return _context.Beers.Find(id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Beer beer)
        {
            _context.Entry(beer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
