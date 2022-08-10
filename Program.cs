using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //*************************** Generate Fibonacci ***********************
            FibCreater fibCreater = new FibCreater();
                 fibCreater.createFib();
            Console.WriteLine("\n");
            //**********************************************************************
            //
            //  
            //************************** Generate Triangle ************ 

            GeometricShapes geometricShapes = new GeometricShapes();
            geometricShapes.triangle();
            Console.WriteLine("\n");
            geometricShapes.circle();
            Console.WriteLine("\n");
            //*********************************************************************

            //*********************************************************************
            //
            //  
            //*************************** Delete Character ****************************
            DeleteChar deleteChar = new DeleteChar();
                deleteChar.readVariables();
            Console.WriteLine("\n");

            //*********************************************************************

            //*************************** Reverse Text ****************************
            ReverseText reverseText = new ReverseText();
            reverseText.reverseText();

            //*********************************************************************


            Console.Read();
        }
    }
}
