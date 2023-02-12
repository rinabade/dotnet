using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApexRestaurant.Services
{
    public interface IGenericService<T>
    {
        IList<T> GetAll();

        T GetById(int id);

        void Insert(T entity);

        void Update(T entity);

        void Delete(T entity);

    }
    
}