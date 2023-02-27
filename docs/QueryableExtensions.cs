using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace Cps_x35
{
    /// <summary
    /// https://stackoverflow.com/a/51583047 &&
    /// https://stackoverflow.com/a/67901042
    /// </summary> 
    public static class QueryableExtensions
    {
        public static string ToSql<TEntity>(this IQueryable<TEntity> query) where TEntity : class
        {
            using var enumerator = query.Provider.Execute<IEnumerable<TEntity>>(query.Expression).GetEnumerator();
            var relationalCommandCache = enumerator.Private("_relationalCommandCache");
            var selectExpression = relationalCommandCache.Private<SelectExpression>("_selectExpression");
            var factory = relationalCommandCache.Private<IQuerySqlGeneratorFactory>("_querySqlGeneratorFactory");
            var relationalQueryContext = enumerator.Private<RelationalQueryContext>("_relationalQueryContext");

            /// Dotnet core 3.1
            ///var parameterValueBasedSelectExpressionOptimizer = relationalCommandCache.Private<ParameterValueBasedSelectExpressionOptimizer>("_parameterValueBasedSelectExpressionOptimizer");
            ///(selectExpression, _) = parameterValueBasedSelectExpressionOptimizer.Optimize(selectExpression, relationalQueryContext.ParameterValues);

            var sqlGenerator = factory.Create();
            var command = sqlGenerator.GetCommand(selectExpression);

            string sql = command.CommandText;
            return sql;
        }

        private static object Private(this object obj, string privateField) => obj?.GetType().GetField(privateField, BindingFlags.Instance | BindingFlags.NonPublic)?.GetValue(obj);
        private static T Private<T>(this object obj, string privateField) => (T)obj?.GetType().GetField(privateField, BindingFlags.Instance | BindingFlags.NonPublic)?.GetValue(obj);
    }
}
