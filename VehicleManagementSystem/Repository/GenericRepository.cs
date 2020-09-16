using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using VehicleManagementSystem.Models;

namespace VehicleManagementSystem.Repository
{
    public class GenericRepository<T>:IGenericRepository<T> where T:class
    {
        private ApplicationDbContext _context = null;
        private DbSet<T> table = null;

        public GenericRepository()
        {
            this._context = new ApplicationDbContext();
            this.table = _context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(object id)
        {
            return table.Find(id);
        }

        public void Insert(T obj)
        {
            table.Add(obj);
        }

        public void Update(T obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(object id)
        {
            T obj = table.Find(id);
            table.Remove(obj);
        }


        public void Save()
        {
            _context.SaveChanges();
        }
    }
}