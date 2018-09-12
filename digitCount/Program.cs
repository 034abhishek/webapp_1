using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountDigit(123456789));
            Console.ReadLine();
        }

        public static int CountDigit(int n)
        {
            int count = 0;
            while(n>0)
            {
                n = n / 10;
                count++;
            }
            return count;
        }
    }
}
