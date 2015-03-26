using System.Linq;

namespace GenericRepository.Repositories
{
    public interface IGenericRepository<TEntity>
    {
        IQueryable<TEntity> All();

        void Add(TEntity entity);

        void Delete(TEntity entity);

        void Update(TEntity entity);
    }
}
