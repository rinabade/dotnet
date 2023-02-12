using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApexRestaurant.Repository;
using System.Collections.Generic;

namespace ApexRestaurant.Services
{
    public class GenericService<T> : IGenericService<T>
        where T : class, new()
    {
        protected GenericService(IGenericRepository<T> entityRepository)
        {
            EntityRepository = entityRepository;
        }
        protected IGenericRepository<T> EntityRepository { get; }
        public void Insert(T entity)
        {
            EntityRepository.Insert(entity);
        }
        public void Update(T entity)
        {
            EntityRepository.Update(entity);
        }
        public IList<T> GetAll()
        {
            return EntityRepository.Query().ToList();
        }
        public T GetById(int id)
        {
            return EntityRepository.Get(id);
        }
        public void Delete(T entity)
        {
            EntityRepository.Delete(entity);
        }
    }
}