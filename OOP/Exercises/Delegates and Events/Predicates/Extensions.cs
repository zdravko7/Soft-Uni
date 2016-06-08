using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicates
{
    public static class Extensions
    {
        public static T FirstOrD<T>(this IEnumerable<T> collection, Predicate<T> condition)
        {
            foreach (var item in collection)
            {
                if (condition(item))
                {
                    return item;
                }
            }

            return default(T);
        }
    }
}
