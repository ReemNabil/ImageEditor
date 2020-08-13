using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEditor
{
    class Program
    {
        static void Main(string[] args)
        {

            CompoundGraphic root = new CompoundGraphic();

            root.Add(new Circle(2,4, 5));
            root.Add(new Circle(2, 4, 5));
            root.Add(new Circle(2, 4, 5));

            Dot leaf = new Dot(4,8);

            root.Add(leaf);
            
            root.Remove(leaf);
            Console.ReadKey();

        }
    }
}
