using FCamara.Domain.Core.Interfaces.Repositorys;
using FCamara.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace FCamara.Domain.Service.Services
{
    public abstract class BaseServices<TEntity> : IDisposable, IBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> baseRepository;

        public BaseServices(IBaseRepository<TEntity> baseRepository)
        {
            this.baseRepository = baseRepository;
        }
        public virtual void Add(TEntity obj)
        {
            baseRepository.Add(obj);
        }
        public virtual TEntity GetById(Guid id)
        {
            return baseRepository.GetById(id);
        }
        public virtual IEnumerable<TEntity> GetAll()
        {
            return baseRepository.GetAll();
        }
        public virtual void Update(TEntity obj)
        {
            baseRepository.Update(obj);
        }
        public virtual void Remove(TEntity obj)
        {
            baseRepository.Remove(obj);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
