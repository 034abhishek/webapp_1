using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerofTwo
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine( Poweroftwo(1));
            Console.ReadLine();
        }

        public static bool Poweroftwo(int num)
        {
            bool output = true;
            if (num == 0)
                output = false;
            else if (num == 1)
                output = true;
            else

                while (num > 0)
                {

                    int r = num % 2;
                    if (r == 0)
                    {
                        int q = num / 2;
                        num = q;
                    }
                    else
                        output = false;
                    break;

                }
            
              return output;
           
         }
    }
}
