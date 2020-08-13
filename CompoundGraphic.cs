using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEditor
{
    class CompoundGraphic : Graphic
    {

        private List<Graphic> _children = new List<Graphic>();


        public override void Add(Graphic c)
        {
            _children.Add(c);
        }

        public override void draw()
        {
            throw new NotImplementedException();
        }

        public override void Move(int x, int y)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Graphic c)
        {
            _children.Remove(c);
        }
    }
}
