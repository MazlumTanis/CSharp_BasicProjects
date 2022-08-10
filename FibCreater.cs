using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProjects
{
    internal class FibCreater
    {


        public List<int> createFib()
        {

            List<int> fib = new List<int>();
            int sum;


            int fibdeep;
            Console.Write("Please enter fibbonacci deep: ");
            if (!int.TryParse(Console.ReadLine(), out fibdeep) || fibdeep <= 0)
            {
                Console.WriteLine("Error negative number");
            }
            int num1 = 1, num2 = 0, toSum;
            fib.Add(num1);
            for (int i = 1; i <= fibdeep - 1; i++)
            {
                toSum = num1 + num2;
                fib.Add(toSum);
                num2 = num1;
                num1 = toSum;
            }
            sum = sumAvg(fib);
            Console.WriteLine(sum);
            return fib;
        }

        public int sumAvg(List<int> fib)
        {
            int sum = 0;

            foreach (int item in fib)
            {
                sum += item;
            }

            return sum;
        }


    }
}
