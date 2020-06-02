using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            IControl button1 = new Button();
            IControl button2 = new Button();
            IControl button3 = new Button();
            IControl button4 = new Button();

            List<IControl> buttons = new List<IControl>();
            buttons.Add(button1);
            buttons.Add(button2);

            IControl container = new Container(buttons);

            List<IControl> controlsInSurface = new List<IControl>();
            controlsInSurface.Add(button3);
            controlsInSurface.Add(container);

            IControl innerSurface = new Surface(controlsInSurface);

            IControl outerSurface = new Surface(new List<IControl>() {innerSurface, button4 });
            Console.WriteLine(outerSurface.Size);

        }
    }
}
