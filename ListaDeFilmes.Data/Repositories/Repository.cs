using ListaDeFilmes.Data.EF;
using ListaDeFilmes.Domain.Contracts.Repositories;
using ListaDeFilmes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace ListaDeFilmes.Data.Repositories
{
    public class Repository<T>: IRepository<T> where T: Entity
    {
        protected readonly FilmesDataContext _ctx = new FilmesDataContext();

        public T Add(T entidade)
        {
            _ctx.Set<T>().Add(entidade);
            salvar();
            return entidade;
        }

        public T Edit(T entidade)
        {
            _ctx.Entry(entidade).State = System.Data.Entity.EntityState.Modified;
            salvar();
            return entidade;
        }

        public void Del(T entidade)
        {
            _ctx.Set<T>().Remove(entidade);
            salvar();
        }

        public IEnumerable<T> Get()
        {
            return _ctx.Set<T>().ToList();
        }

        public async Task<IEnumerable<T>> GetAsync()
        {
            return await _ctx.Set<T>().ToListAsync();

        }

        public T Get(object id)
        {
            return _ctx.Set<T>().Find(id);
        }

        public async Task<T> GetAsync(object id)
        {
            return await _ctx.Set<T>().FindAsync(id);
        }

        private void salvar()
        {
            _ctx.SaveChanges();
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}
