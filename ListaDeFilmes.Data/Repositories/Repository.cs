using ListaDeFilmes.Domain.Contracts.Repositories;
using ListaDeFilmes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeFilmes.Data.Repositories
{
    class Repository<T>: IRepository<T> where T: Entity
    {
        public T Add(T entidade)
        {
            throw new NotImplementedException();
        }

        public T Edit(T entidade)
        {
            throw new NotImplementedException();
        }

        public void Del(T entidade)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Get()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public T Get(object id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync(object id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
