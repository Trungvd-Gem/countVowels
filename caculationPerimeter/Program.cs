using System;
using System.Text;

namespace caculationPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the long of the rectangular: ");
            double rLength = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the width of the rectangular: ");
            double rWidth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter radius of the circle: ");
            double cRadius = Convert.ToInt32(Console.ReadLine());

            double perimeterRec, perimeterCir;
            perimeterRec = 2 * (rLength + rWidth);
            perimeterCir = 2 * cRadius * Math.PI;

            Console.Write("The perimeter of the rectangular: " + perimeterRec);
            Console.Write("\n\n");
            Console.Write("The perimeter of the circle: " + perimeterCir);

            Console.ReadLine();

        }
    }
}

