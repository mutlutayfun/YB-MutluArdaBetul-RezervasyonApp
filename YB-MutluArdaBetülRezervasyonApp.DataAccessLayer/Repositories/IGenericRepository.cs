using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Abstractions;
using YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Context;
using YB_MutluArdaBetülRezervasyonApp.Entities.Abstractions;

namespace YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Repositories
{
    public class IGenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public IGenericRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            _dbSet.Remove(GetByID(id));
            _context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T? GetByID(Guid id)
        {
            return _dbSet.Find(id);
        }

        public void Update(T entity)
        {
            _context.SaveChanges();
        }
    }
}
