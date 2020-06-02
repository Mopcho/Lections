using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public abstract class Control : IControl
    {
        public abstract double Size
        {
            get;
        }
    }
}
