using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Faust.DTO
{
    public class AutoDTOMapper<T, TDTO>
    {
        private static Expression<Func<T, TDTO>> _expression;

        public virtual Expression<Func<T, TDTO>> Map()
        {
            if (_expression != null) return _expression;

            var sourceMembers = typeof(T).GetProperties();
            var destinationMembers = typeof(TDTO).GetProperties().Where(d => sourceMembers.Any(s => s.PropertyType == d.PropertyType && s.Name == d.Name));

            const string name = "src";
            var parameterExpression = Expression.Parameter(typeof(T), name);

            _expression = Expression.Lambda<Func<T, TDTO>>(
                Expression.MemberInit(
                    Expression.New(typeof(TDTO)),
                    destinationMembers.Select(dest => Expression.Bind(dest,
                        Expression.Property(
                            parameterExpression,
                            sourceMembers.First(pi => pi.Name == dest.Name)
                            )
                        )).ToArray()
                    ),
                parameterExpression
                );

            return _expression;
        }
    }
}
