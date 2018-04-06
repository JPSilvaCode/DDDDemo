using DDDDemo.Dominio.Interfaces.Repositorio.Base;
using DDDDemo.Infraestrutura.Dados.Contexto.Contexto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DDDDemo.Infraestrutura.Dados.Repository.Repositorio.Base
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {        
        protected DDDDemoContext _context;
        protected readonly IDbSet<TEntity> _dbset;

        public RepositoryBase(DDDDemoContext context)
        {
            _context = context;
            _dbset = context.Set<TEntity>();
        }

        public void Add(TEntity obj)
        {
            _context.Set<TEntity>().Add(obj);            
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            _context.Set<TEntity>().Remove(obj);            
        }

        public void Update(TEntity obj)
        {
            _context.Entry(obj).State = EntityState.Modified;            
        }
    }
}
