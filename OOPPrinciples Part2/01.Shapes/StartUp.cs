namespace OOPPrinciples_Part2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Shape;

    public class StartUp
    {
        static void Main()
        {
            // Test with square

            var listSquare = new List<Square>()
            {
                new Square(2, 2),
                new Square(4, 4),
                new Square(23, 23)
            };

            Console.WriteLine("---------- Square -----------");

            foreach (var square in listSquare)
            {
                Console.WriteLine(square.CalculateSurface());
            }

            // Test with triangle

            var listTriangle = new List<Triangle>()
            {
                new Triangle(12, 3),
                new Triangle(1, 34),
                new Triangle(23, 5)
            };

            Console.WriteLine("---------- Triangle -----------");

            foreach (var triangle in listTriangle)
            {
                Console.WriteLine(triangle.CalculateSurface());
            }

            // Test width rectangle

            var listRectangles = new List<Rectangle>()
            {
                new Rectangle(12, 3),
                new Rectangle(34, 56),
                new Rectangle(12, 45)
            };

            Console.WriteLine("---------- Rectangle -----------");

            foreach (var rectangle in listRectangles)
            {
                Console.WriteLine(rectangle.CalculateSurface());
            }
            
        }
    }
}
