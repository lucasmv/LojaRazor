using System.Linq;

namespace Model.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Insert(TEntity obj);
        TEntity GetById(long id);
        IQueryable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
    }
}
