using CQRS.IRR.Criterias;

namespace CQRS.IRR.Queries
{
    public interface IQueryDispatcher
    {
        TResult Dispatch<TCriteria, TResult>(TCriteria criteria)
            where TCriteria : ICriteria;
    }
}