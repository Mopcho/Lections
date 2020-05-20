using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class TestEvenArgs : EventArgs
    {
        public int Number { get; set; }

        public string Name { get; set; }

        public int Grade { get; set; }

        public TestEvenArgs (int number,string name, int grade)
        {
            this.Number = number;
            this.Name = name;
            this.Grade = grade;
        }

    }
}
