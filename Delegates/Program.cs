using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate bool Predicate<T>(T value);

    class Program
    {
      static IEnumerable<T> Filter<T>(IEnumerable<T> numbers, Predicate<T> predicate)
        {
            var list = new List<T>();

            foreach (var n in numbers)
            {
                if(predicate(n)) {
                    list.Add(n);
                }
            }
            return list;
        }

    //    static bool GreaterThan5(int value)
    //   {
    //      return value > 5;
    //   }

      //  static bool IsEven(int value)
      //  {
      //     return value % 2 == 0;
      //  }

        static bool IsPrime(int value)
        {
            var upperbound = Math.Sqrt(value);

            var IsPrime = true;

            var candidate = 2;

            while (candidate<=upperbound && IsPrime)
            {
                IsPrime = value % candidate != 0;
                candidate++;
            }
            return IsPrime;
        }
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 2, 20, 13, 15,7,17,33,16 };

            var greater = Filter(numbers, delegate (int value)
            {
                return value > 5;
            });

            var even = Filter(numbers, delegate(int value)
            {
                return value % 2 == 0;
            });

            var prime = Filter(numbers, IsPrime);

            Console.WriteLine(greater.StringJoin());
            Console.WriteLine(even.StringJoin());
           // Console.WriteLine(prime.StringJoin());
            
        }
    }
    public static class GenericExtensions
    {
        public static int ToInt32(this string str)
        {
            return int.Parse(str);
        }
        public static string StringJoin<T>(this IEnumerable<T> elements, string separator = ", ")
        {
            return string.Join(separator, elements);
        }

    }
}
