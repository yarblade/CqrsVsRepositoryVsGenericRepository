using System.Linq;
using NHibernate;
using NHibernate.Linq;

namespace GenericRepository.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T>
    {
        private readonly ISession _session;

        public GenericRepository(ISession session)
        {
            _session = session;
        }

        public IQueryable<T> All()
        {
            return _session.Query<T>();
        }

        public void Add(T entity)
        {
            _session.Save(entity);
        }

        public void Delete(T entity)
        {
            _session.Delete(entity);
        }

        public void Update(T entity)
        {
            _session.Update(entity);
        }
    }
}
