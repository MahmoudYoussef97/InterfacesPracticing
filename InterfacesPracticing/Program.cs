using System;

namespace InterfacesPracticing
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(5);
            PrintPolygon("square", square);
            Triangular triangular = new Triangular(4);
            PrintPolygon("triangular", triangular);
            IRegularPolygon octagon = new Octagon(6);
            PrintPolygon("octagon", octagon);
        }
        public static void PrintPolygon(string name, dynamic polygon)
        {
            Console.WriteLine(name);
            Console.WriteLine(polygon.SideLength);
            Console.WriteLine(polygon.NumberOfSides);
            Console.WriteLine(polygon.GetPrimeter());
            Console.WriteLine(polygon.GetArea());
        }
    }
}
