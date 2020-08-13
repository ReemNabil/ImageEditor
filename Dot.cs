using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEditor
{
    //leaf
    class Dot : Graphic
    {
       public int x;
       public  int y; 
        public Dot(int x , int y  )
        {
            this.x = x;
            this.y = y;
        }
        public override void Add(Graphic c)
        {
            Console.WriteLine("Cannot add to a Dot");
        }

     
        public override void draw()
        {
            Console.WriteLine(" Dot at " + x + "," + y);
        }

        public override void Move(int x, int y)
        {
            Dot dot = new Dot(x, y);
            Console.Write(" Dot Move to " );
            dot.draw();
        }

        public override void Remove(Graphic c)
        {
            Console.WriteLine("Cannot Remove to a Dot");
        }
    }
}
