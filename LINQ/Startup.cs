using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Startup
    {
        static void Main()
        {
            var usualSuspects = new String[] { "Peshdasdo", "Tosho", "Gosdfsho", "Shosho", "Kucheto Rex","Stamat" };

            //var shoshovci =
            // from suspect in usualSuspects
            //where suspect.EndsWith("sho") || suspect.Contains("Rex")
            // orderby suspect.Length, suspect
            // select $"Usual suspect called {suspect}";

            var shoshovci = usualSuspects
                .Where(name => name.EndsWith("sho") || name.EndsWith("Rex"))
                .OrderBy(suspect => suspect.Length)
                .ThenBy(suspect => suspect)
                .Select(suspect => "Cyber criminal Called " + suspect);




            Console.WriteLine(String.Join("\r\n",shoshovci));
            //var numbers = new int[] { 1, 2, 10, 33, 68, 99 };

            //var sum = numbers.Sum(x=>x & 1 );
            //var sum = numbers.Max(x => x % 19);
            var random = new Random();
            var numbers = Enumerable.Range(0, 5).Select(x=>random.Next()).ToArray();
            // var numbers = Enumerable.Range(0, 10).ToArray();
        }
    }
}
