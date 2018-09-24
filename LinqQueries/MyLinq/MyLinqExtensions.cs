using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQueries.MyLinq
{
    public static class MyLinqExtensions
    {

        public static IEnumerable<T> MyFilter<T>(this IEnumerable<T> source, Func<T, bool> predicate )
        {
            foreach (var item in source)
            {
                if (predicate(item)) yield return item;
            }
        }
    }
}
