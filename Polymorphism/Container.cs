using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
   public  class Container : Control
    {
        private readonly IEnumerable<IControl> controls;

        public Container(IEnumerable<IControl> controls)
        {
            this.controls = controls;
        }

        public IEnumerable<IControl> Controls
        {
            get
            {
                return this.controls;
            }
        }

        public override double Size
        {
            get
            {
                double size = 0;
                foreach (IControl controls in  this.Controls)
                {
                    size += controls.Size;
                }

                return size;
            }
        }


    }
}
