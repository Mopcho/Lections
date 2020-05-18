using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.List
{
    public static class ListExtension
    {
        public static void IncrementAll(this IList<int> numbers)
        {
            IncreaseBy(numbers);
        }
        public static void IncreaseBy(this IList<int> numbers, int by=1 )
        {
            for (int i = 0;i<numbers.Count;i++)
            {
                numbers[i] += by;
            }
        }
    }
}
