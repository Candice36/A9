using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Activity9_2_
{
    class Program
    {
       private static void Main(string[] args)
        {
            double sum = 0, avg = 0;
            double[] numbers = { 10, 20, 50, 40,50 };
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            avg = sum / numbers.Length;
            Console.WriteLine("The Sum is : " + sum);
            Console.WriteLine("The Average is : " + avg);

            Console.ReadKey();
        }
        Exit();
    }
    } 


