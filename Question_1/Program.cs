using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReplaceZero(304)); 
            Console.ReadLine();
        }

        public static double ReplaceZero(double num)
        {
            double Output = 0;
            long index = 0;
            while (num > 0)
            {
                double n = num % 10;
                if (n == 0)
                    n = 5;
                //   Output = (long)(Output + Math.Pow(10, index) * n);
                Output = Convert.ToDouble(Output + Math.Pow(10, index) * n);

                num = num / 10;
                index++;

            }
            return Output ;
           
        }
    }
}
