using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesPracticing
{
    public interface IRegularPolygon
    {
        int NumberOfSides { get; set; }
        int SideLength { get; set; }
        double GetPrimeter();
        double GetArea();
    }
}
