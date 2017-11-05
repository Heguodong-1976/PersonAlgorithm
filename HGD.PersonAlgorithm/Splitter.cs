using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGD.PersonAlgorithm
{
    public static class Splitter
    {
        /// <summary>
        /// Split collection to n
        /// </summary>
        /// <param name="collection">Spliting collection</param>
        /// <param name="n">Splitting count</param>
        /// <returns>n array with same length</returns>
        public static T[][] To_n_Parts<T>(this IEnumerable<T> collection,Int32 n)
        {
            if (collection == null) return null;
            if (collection.Count() % n != 0) return null;
            var len = collection.Count() / n;
            return 0.To(n).Select(i => PeekArray(collection, i, len)).ToArray();
        }

        private static T[] PeekArray<T>(IEnumerable<T> collection, int i, int len)
        {
            return 0.To(len).Select(j => collection.ElementAt(i * len + j)).ToArray();
        }
    }
}
