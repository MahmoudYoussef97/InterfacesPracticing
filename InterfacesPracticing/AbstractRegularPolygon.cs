using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesPracticing
{
    public abstract class AbstractRegularPolygon
    {
        public int SideLength { get; set; }
        public int NumberOfSides { get; set; }
        public AbstractRegularPolygon(int numberOfSides, int sideLength)
        {
            SideLength = sideLength;
            NumberOfSides = numberOfSides;
        }
        public double GetPrimeter()
        {
            return NumberOfSides * SideLength;
        }
        public abstract double GetArea();
    }
}
