using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageFeatures.MyExtensions
{
    public static class MyLinqExtension
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> source, Func<T, bool> myFilterFunction)
        {
            List<T> result = new List<T>();

            foreach (var item in source)
            {
                if (myFilterFunction(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public static int Count<typen>(this IEnumerable<typen> sequence)
        {
            var count = 0;
            foreach (var item in sequence)
            {
                count = count + 1;
            }
            return count;
        }
    }
}
