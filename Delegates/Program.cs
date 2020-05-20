using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
   public delegate bool Predicate<T>(T value, int index);

    
        public static class IEnumerableExtensions
        {
            public static IEnumerable<T> Filter<T>(this IEnumerable<T> numbers, Predicate<T> predicate)
            {
                var list = new List<T>();

                var index = 0;

                foreach (var n in numbers)
                {
                    if (predicate(n,index++))
                    {
                        list.Add(n);
                    }
                }
                return list;
            }
        }

    //    static bool GreaterThan5(int value)
    //   {
    //      return value > 5;
    //   }

    //  static bool IsEven(int value)
    //  {
    //     return value % 2 == 0;
    //  }
    class Program
    {
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

            var even =numbers.Filter( (value, index) => value % 2 == 0);

            var words = new string[] { "gosho", "kaun", "dinq", "metla" };

            var shortWords = words.Filter((word, index ) => word.Length <= 4);

            Console.WriteLine(shortWords.StringJoin());

            Console.WriteLine(even.StringJoin());
            // var even = Filter(numbers, delegate (int value)
            // {
            //     return value % 2 == 0;
            // });

            // var shortWords = Filter(words, delegate (string w)
            // {
            //     return w.Length <= 4;
            // });
            //var shortWords = Filter(words, word => word.Contains('a'));

            // var greater = Filter(numbers, delegate (int value)
            //  {
            //      return value > 5;
            //  });

            //var prime = Filter(numbers, IsPrime);

            // Console.WriteLine(greater.StringJoin());

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
