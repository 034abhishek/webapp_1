using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_FirstQue
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            Console.WriteLine("Enter the length of array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] number = new int[n];
            Console.WriteLine("Enter the element of array:");
            for (i=0; i<n;i++)
            {
                
               number[i]= Convert.ToInt32(Console.ReadLine());
            }
            for (i =number.Length-1; i>=0; i--)
           {

                Console.WriteLine(number[i]);
            }
           Console.ReadLine();
        }
    }
}
