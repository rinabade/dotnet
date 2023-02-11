using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApexRestaurant.Repository
{
    public interface IGenericRepository<T>
    {

        T Get(int id);

        IQueryable<T> Query();

        void Insert(T entity);

        void Update(T entity);

        void Delete(T entity);

    }
}