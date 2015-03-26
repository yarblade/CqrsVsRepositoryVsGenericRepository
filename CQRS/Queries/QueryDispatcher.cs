using CQRS.IRR.Criterias;
using CQRS.IRR.DependencyResolver;

namespace CQRS.IRR.Queries
{
   public class QueryDispatcher : IQueryDispatcher
   {
       private readonly IDependencyResolver _resolver;

       public QueryDispatcher(IDependencyResolver resolver)
       {
           _resolver = resolver;
       }

       public TResult Dispatch<TCriteria, TResult>(TCriteria criteria)
            where TCriteria : ICriteria
        {
            var query = _resolver.Resolve<IQuery<TCriteria, TResult>>();
            return query.Ask(criteria);
        }
    }
}
