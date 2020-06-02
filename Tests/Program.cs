using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
   
    class Program
    {
        static void Main()
        {
            var math = new Math(1);
            math.X = -1;
            Console.WriteLine(math.X); 
        }
    }
}
