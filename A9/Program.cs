using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            double avg;

            Console.Write("\n\n");
            Console.Write("Read 2 numbers and calculates sum and average:\n");

            Console.Write("\n\n");
            Console.Write("Input the 2 numbers : \n");
            for (i = 1; i <= 2; i++)
            {

                Console.Write("Number-{0} :", i);
                n = Convert.ToInt32(Console.ReadLine());
                sum += n;
            }
            avg = sum / 2.0;
            Console.Write("The sum of 2 no is : " + sum);
            Console.Write("The average is : " + avg);

            Console.ReadKey();

        }

        
            

            

            
    }
}
