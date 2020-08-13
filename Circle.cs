using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEditor
{
    class Circle : Dot 
    {
       public  int radius;
        public Circle(int x , int y , int radius) :base(x,y)
        {
            this.radius = radius;

        }

        public override void draw()
        {
            Console.WriteLine(" Circle at " + x + "," + y +"With radius " + radius);
        }

    }
}
