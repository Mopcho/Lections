using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypes
{
    class Program
    {
        static void Main()
        {
            var list = new List<int>() { 1 };
            var point = new { X = 10, Y = 12 };
            var point2 = new { X = 10, Y = 12 };
            var hoomans = new[]
            {
                new {Name="Pesho", Age =13},
                new {Name="Tarzan", Age = 30},
                new {Name = "Haralampi", Age = 28}
            };
            foreach (var hooman in hoomans)
            {
                Console.WriteLine(hooman.Name);
            }
            Console.WriteLine(point == point2);
            Console.WriteLine(point.Equals(point2));
        }
    }
}
