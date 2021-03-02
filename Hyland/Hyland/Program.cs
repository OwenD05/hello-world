using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyland
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Console.WriteLine("Enter height of a Rectangle");

            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter width of a Rectangle");

            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Rectangle rectangle = new Rectangle(width, height);

            Console.WriteLine("The area is:");
            Console.WriteLine(rectangle.GetArea());
               
            Console.WriteLine("The perimeter is:");
            Console.WriteLine(rectangle.GetPerimeter());

            Console.WriteLine("Enter length of one side of a Square");
            int length = Convert.ToInt32(Console.ReadLine());
            Square square = new Square(length);
            Console.WriteLine("The area is: ");
            Console.WriteLine(square.GetArea());

            List<Rectangle> rectangles = new List<Rectangle>();
            rectangles.Add(rectangle);

            foreach(Rectangle r in rectangles)
            {
                Console.WriteLine(r.ToString());
            }

            Console.ReadLine();
        }
    }
    
}
