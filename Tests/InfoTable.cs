using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class Math
    {
         public int X { get;set; }
         public Math(int x)
         {
            if (x < 0)
            {
                throw new Exception("adfafas");
            }
            this.X = x;
         }
    }
}
