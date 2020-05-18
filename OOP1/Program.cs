using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP1.List;
using OOP1.Generic;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 5, 10, 33, 66 };
            // numbers.IncrementAll();
            //Console.WriteLine(String.Join(", ", numbers));
            //var n = Console.ReadLine().ToInt32();
            Console.WriteLine(numbers.StringJoin());
        }
    }
}
