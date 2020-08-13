using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEditor
{
    abstract class Graphic
    {

        public abstract void Move(int x , int y);

        public abstract void draw();
        public abstract void Add(Graphic c);

        public abstract void Remove(Graphic c);

    }
}
