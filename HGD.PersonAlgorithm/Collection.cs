using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGD.PersonAlgorithm
{
    public static class Collection
    {
        public static IEnumerable<Int32> To(this Int32 start, Int32 end)
        {
            for (var i = start; i < end; ++i)
                yield return i;
        }
    }
}
