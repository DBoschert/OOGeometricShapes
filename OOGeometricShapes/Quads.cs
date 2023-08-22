using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOGeometricShapes
{
    internal class Quads
    {
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }
        public int Side4 { get; set; }

        public int Perimeter(int s1, int s2, int s3, int s4)
        {
            return s1 + s2 + s3 + s4;
        }

        public Quads(int s1, int s2, int s3, int s4)
        {
            this.Side1 = s1; this.Side2 = s2; this.Side3 = s3; this.Side4 = s4;
        }

    }
}
