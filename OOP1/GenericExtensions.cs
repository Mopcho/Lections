using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Generic
{
    public static class GenericExtensions
    {
        public static int ToInt32(this string str)
        {
            return int.Parse(str);
        }
        public static string StringJoin<T>(this IEnumerable<T> elements,string separator=", ")
        {
            return string.Join(separator, elements);
        }
       
    }
}
