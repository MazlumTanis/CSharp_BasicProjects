using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProjects
{
    internal class GeometricShapes
    {

        public void triangle()
        {
            int triangleScale;
            Console.Write("Please enter the scale: ");
            if (!int.TryParse(Console.ReadLine(), out triangleScale) || triangleScale <= 0)
            {
                Console.WriteLine("Error negative number");
                return;
            }
            for (int i = 0; i < triangleScale; i++)
            {
                for (int k = triangleScale; k > i; k--)
                {
                    Console.Write(' ');
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine('\n');
            }
        }

        public void circle()
        {
            double radius;
            double thickness = 0.4;

            Console.Write("Please enter the radius: ");
            if (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
            {
                Console.WriteLine("Error negative number");
                return;
            }

            while (radius <= 0) ;

            Console.WriteLine();
            double rin = radius - thickness, rOut = radius + thickness;

            for (double y = radius; y >= -radius; --y)
            {
                for (double x = -radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rin * rin && value <= rOut * rOut)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }



        }

    }
}
