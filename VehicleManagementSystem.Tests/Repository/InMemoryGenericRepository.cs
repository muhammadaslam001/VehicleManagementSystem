using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementSystem.Repository;
using VehicleManagementSystem.Models;

namespace VehicleManagementSystem.Tests.Repository
{
    public class InMemoryGenericRepository<T> : IGenericRepository<T> where T : class
    {
        List<T> _listCars = null;
        public InMemoryGenericRepository(List<T> listCars)
        {
            this._listCars = listCars;
        }

        public IEnumerable<T> GetAll()
        {
            return _listCars;
        }
        public void Insert(T obj)
        {
            _listCars.Add(obj);
        }

        public T GetById(object id)
        {
            T obj = _listCars.SingleOrDefault(c => c == id);
            return obj;
        }


        public void Update(T obj)
        {
            T car = _listCars.SingleOrDefault(c => c == obj);
            _listCars.Remove(car);
            _listCars.Add(car);

        }
        public void Delete(object id)
        {
            T car = _listCars.SingleOrDefault(c => c == id);
            _listCars.Remove(car);
            throw new NotImplementedException();
        }
        public void Save()
        {
            //nothing...
        }

    }
}
