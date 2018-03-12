using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstract
{
    public interface IRepository<TEntity> where TEntity: class
    {
        IEnumerable<TEntity> GetRepository();
        void InsertEntity(TEntity entity);
        void DeleteEntity(TEntity entityToDelte);
        void UpdateEntity(TEntity entityToUpdate);

    }
}
