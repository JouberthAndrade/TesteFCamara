using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FCamara.Domain.Core.Interfaces.Repositorys
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<TEntity> Add(TEntity obj);

        TEntity GetById(Guid id);

        IEnumerable<TEntity> GetAll();

        void Update(TEntity obj);

        void Remove(TEntity obj);

        void Dispose();
    }
}
