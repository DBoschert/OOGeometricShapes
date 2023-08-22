using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOGeometricShapes
{
    internal class Square : Rects
    {
        public Square(int s1) : base(s1, s1)
        {

        }

        public int Area(int s1)
        {
            return Area(s1, s1);
        }
    }
}