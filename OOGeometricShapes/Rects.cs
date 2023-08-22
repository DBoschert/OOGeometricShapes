using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOGeometricShapes
{
    internal class Rects : Quads
    {
        public int Area(int s1, int s2)
        {
            return s1 * s2;
        }

        public Rects(int s1, int s2) : base(s1, s2, s1, s2)
        {
           
        }
    }
}
