using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesPracticing
{
    public class Octagon : IRegularPolygon
    {
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }
        public Octagon(int sideLength)
        {
            NumberOfSides = 8;
            SideLength = sideLength;
        }
        public double GetArea()
        {
            return NumberOfSides * SideLength;
        }
        public double GetPrimeter()
        {
            return SideLength * SideLength * (2 + 2 * Math.Sqrt(2));
        }
    }
}
