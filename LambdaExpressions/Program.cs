using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {

        static void Main()
        {
            var numbers = new int[] { 10, 1, -7, 33, 4, -5 };

            var odd = numbers.Where((value, index) => index % 2 == 1).ToList();

            Console.WriteLine(String.Join(", ", odd));
        }
    }
}
