using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace LambdaExpressions
{
    class Program
    {

        static void Main()
        {
            Func<int, bool> isOdd = n => n % 2 == 1;
            Func<int, int, int> sum = (a, b) => a + b;
            Func<string, int> parse = int.Parse;

            Action<string> saveToFile = text => File.AppendAllText("./Gosho.txt", text + "\r\n");

            var words = new List<string> { "kaun", "metla", "c#", "javascript", "sdfs" };

            words.ForEach(w => File.AppendAllText("./Gosho.txt", w + "\r\n"));

            //foreach (var w in words)
            //{
            //    saveToFile(w);
            // }

            //var numbers = new int[] { 10, 1, -7, 33, 4, -5 };
            //var odd = numbers.Where(isOdd).ToList();

            //var odd = numbers.Where((value, index) => index % 2 == 1).ToList();

            //Console.WriteLine(String.Join(", ", odd));
            //var sumOfNum = 0;

            //foreach (var n in numbers)
            //{
            //    sumOfNum = sum(sumOfNum, n);
            //}
            //Console.WriteLine(sumOfNum);
            //for (int i=0;i<10;i++)
            //{
            //    Console.WriteLine(i+" is odd" + isOdd(i));
            //}
        }
    }
}
