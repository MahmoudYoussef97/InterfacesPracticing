using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesPracticing
{
    public class Triangular : AbstractRegularPolygon
    {
        public Triangular(int sideLength)
            :base(3, sideLength)
        {
        }
        public override double GetArea()
        {
            return SideLength * SideLength * Math.Sqrt(3) / 4;
        }
        public double GetPerimeter()
        {
            return SideLength * NumberOfSides;
        }
    }
}
