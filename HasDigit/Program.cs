using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HasDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(hasdigit(1234,5));
            Console.ReadLine();
        }

        public static bool hasdigit(int a,int b)
        {
            bool has = false;
            while(a>0)
            {
                int temp = a % 10;
                if (temp == b)
                {
                    has = true;
                    break;
                }
                a = a / 10;

            }
            return has;
        }
    }
}
