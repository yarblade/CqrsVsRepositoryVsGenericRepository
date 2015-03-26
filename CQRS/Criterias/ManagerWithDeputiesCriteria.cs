using System;
using System.Linq.Expressions;
using Entities;

namespace CQRS.IRR.Criterias
{
    public class ManagerWithDeputiesCriteria : ListCriteria
    {
        private readonly Expression<Func<Manager, bool>> _expression;

        public ManagerWithDeputiesCriteria(Expression<Func<Manager, bool>> expression)
        {
            _expression = expression;
        }

        public Expression<Func<Manager, bool>> Expression
        {
            get { return _expression; }
        }
    }
}