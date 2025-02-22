using DesignPattern.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.RepositoryPattern
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private DesignPatternContext _context;
        private DbSet<TEntity> _dbSet;

        public Repository(DesignPatternContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            var dataToDelete = _dbSet.Find(entity);  
            _dbSet.Remove(dataToDelete);
        }

        public IEnumerable<TEntity> Get()
        {
            return _dbSet.ToList();
        }

        public TEntity Get(int id)
        {
            return _dbSet.Find(id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
