using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action
{
    public static class Extensions
    {
        public static void ForEach<T>(this IEnumerable<T> collection, Delegate condition)
        {
            condition(string.Join(", ", collection));
        }
    }
}
