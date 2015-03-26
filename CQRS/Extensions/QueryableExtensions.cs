using System.Linq;
using CQRS.IRR.Criterias;

namespace CQRS.IRR.Extensions
{
    public static class Extensions
    {
        public static IQueryable<T> Apply<T>(this IQueryable<T> query, ListCriteria criteria)
        {
            if (criteria.Skip > 0)
            {
                query = query.Skip(criteria.Skip);
            }

            if (criteria.Take > 0)
            {
                query = query.Take(criteria.Take);
            }

            return query;
        }
    }
}