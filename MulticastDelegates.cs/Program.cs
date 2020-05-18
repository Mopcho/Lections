using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegates.cs
{
    public delegate void Print(string str);

    class Program
    {
        static void PrintStr(string str)
        {
            Console.WriteLine(str);
        }
        static void PrintUpperCase(string str)
        {
            Console.WriteLine(str.ToUpper());
        }
        static void PrintGreen(string str)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(str);
            Console.ForegroundColor = ConsoleColor.Black;
        }
        static void Main()
        {
            Print printAllThePrinting = delegate (string str)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(str);
                Console.ForegroundColor = ConsoleColor.Black;
            };
           printAllThePrinting += delegate (string str)
            {
                Console.WriteLine(str.ToUpper());
            };
            printAllThePrinting("Ninja Turtles");


        }
    }
}
