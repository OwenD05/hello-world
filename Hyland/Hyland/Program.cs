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

            Console.ReadLine();
        }
    }
    
}
