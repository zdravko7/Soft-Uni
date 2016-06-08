using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func
{
    public static class Extensions
    {
        public static IEnumerable<T> TakeWhile<T>(this IEnumerable<T> collection, Func<T, bool> condition) 
        {
            List<T> collectionMeetingCondition = new List<T>();

            foreach (var item in collection)
	        {
		        if(condition(item))
                {
                    collectionMeetingCondition.Add(item);
                }
	        }

            return collectionMeetingCondition;
        }
    }
}
