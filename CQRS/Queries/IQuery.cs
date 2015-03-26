using CQRS.IRR.Criterias;

namespace CQRS.IRR.Queries
{
    public interface IQuery<in TCriteria, out TResult>
        where TCriteria : ICriteria
    {
        TResult Ask(TCriteria criteria);
    }
}
