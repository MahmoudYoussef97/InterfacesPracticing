using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesPracticing
{
    public class ConcreteRegularPolygon
    {
        public int SideLength { get; set; }
        public int NumberOfSides { get; set; }
        public ConcreteRegularPolygon(int numberOfSides, int sideLength)
        {
            SideLength = sideLength;
            NumberOfSides = numberOfSides;
        }
        public double GetPrimeter()
        {
            return NumberOfSides * SideLength;
        }
        public virtual double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
