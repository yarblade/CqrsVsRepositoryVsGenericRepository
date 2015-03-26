using CQRS.IRR.Criterias;

namespace CQRS.IRR.Queries
{
    public class QueryFor<TResult>
    {
        private readonly IQueryDispatcher _dispatcher;

        public QueryFor(IQueryDispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }

        public TResult By<TCriteria>(TCriteria criteria)
            where TCriteria : ICriteria
        {
            return _dispatcher.Dispatch<TCriteria, TResult>(criteria);
        }
    }
}
