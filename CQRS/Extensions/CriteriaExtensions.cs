using CQRS.IRR.Criterias;

namespace CQRS.IRR.Extensions
{
    public static class CriteriaExtensions
    {
        public static TCriteria SetSkip<TCriteria>(this TCriteria criteria, int count)
            where TCriteria : ListCriteria
        {
            criteria.Skip = count;
            return criteria;
        }

        public static TCriteria SetTake<TCriteria>(this TCriteria criteria, int count)
            where TCriteria : ListCriteria
        {
            criteria.Take = count;
            return criteria;
        }
    }
}
