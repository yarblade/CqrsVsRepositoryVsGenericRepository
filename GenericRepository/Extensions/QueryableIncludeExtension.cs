using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using NHibernate.Linq;

namespace GenericRepository.Extensions
{
    public static class QueryableIncludeExtension
    {
        public static IQueryable<T> Include<T, TProperty>(
            this IQueryable<T> queryable,
            Expression<Func<T, TProperty>> selector)
        {
            return queryable.Fetch(selector);
        }

        public static IQueryable<T> Include<T, TProperty, TSecondProperty>(
            this IQueryable<T> queryable,
            Expression<Func<T, TProperty>> selector,
            Expression<Func<TProperty, TSecondProperty>> secondSelector)
        {
            return queryable.Fetch(selector).ThenFetch(secondSelector);
        }

        public static IQueryable<T> Include<T, TProperty, TSecondProperty, TThirdProperty>(
            this IQueryable<T> queryable,
            Expression<Func<T, TProperty>> selector,
            Expression<Func<TProperty, TSecondProperty>> secondSelector,
            Expression<Func<TSecondProperty, TThirdProperty>> thirdSelector)
        {
            return queryable.Fetch(selector).ThenFetch(secondSelector).ThenFetch(thirdSelector);
        }

        public static IQueryable<T> Include<T, TProperty>(
            this IQueryable<T> queryable,
            Expression<Func<T, IEnumerable<TProperty>>> selector)
        {
            return queryable.FetchMany(selector);
        }

        public static IQueryable<T> Include<T, TProperty, TSecondProperty>(
            this IQueryable<T> queryable,
            Expression<Func<T, IEnumerable<TProperty>>> selector,
            Expression<Func<TProperty, TSecondProperty>> secondSelector)
        {
            return queryable.FetchMany(selector).ThenFetch(secondSelector);
        }

        public static IQueryable<T> Include<T, TProperty, TSecondProperty, TThirdProperty>(
            this IQueryable<T> queryable,
            Expression<Func<T, IEnumerable<TProperty>>> selector,
            Expression<Func<TProperty, IEnumerable<TSecondProperty>>> secondSelector,
            Expression<Func<TSecondProperty, TThirdProperty>> thirdSelector)
        {
            return queryable.FetchMany(selector).ThenFetchMany(secondSelector).ThenFetch(thirdSelector);
        }

        public static IQueryable<T> Include<T, TProperty, TSecondProperty, TThirdProperty>(
            this IQueryable<T> queryable,
            Expression<Func<T, IEnumerable<TProperty>>> selector,
            Expression<Func<TProperty, IEnumerable<TSecondProperty>>> secondSelector,
            Expression<Func<TSecondProperty, IEnumerable<TThirdProperty>>> thirdSelector)
        {
            return queryable.FetchMany(selector).ThenFetchMany(secondSelector).ThenFetchMany(thirdSelector);
        }
    }
}