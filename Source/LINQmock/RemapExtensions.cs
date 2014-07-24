// Licensed under the Apache 2.0 License. See LICENSE.txt in the project root for more information.

using LinqMock.Maps;
using System.Linq;
using System.Linq.Expressions;

namespace LinqMock
{
    public static class RemapExtensions
    {
        public static IQueryable<T> Remap<T>(this IQueryable<T> source, ILinqMap map)
        {
            return source.Provider.CreateQuery<T>(Remap(source.Expression, map));
        }

        public static Expression Remap(Expression expression, ILinqMap map)
        {
            return new RemappingVisitor(map).Visit(expression);
        }

        private class RemappingVisitor : ExpressionVisitor
        {
            private readonly ILinqMap map;

            internal RemappingVisitor(ILinqMap map)
            {
                this.map = map;
            }

            protected override Expression VisitMethodCall(MethodCallExpression node)
            {
                var replacement = map.GetReplacement(node.Method);
                return replacement == null
                    ? base.VisitMethodCall(node)
                    : Expression.Call(node.Object, replacement.Method, node.Arguments);
            }
        }
    }
}