using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question
{
    class Program
    {
      
        static void Main(string[] args)
        {
            summ(5,4);
        }

        public static void summ(int a,int b)
        {
            int s = a + b;
            Console.WriteLine(s);
            Console.ReadLine();
           // return s;
        }
    }
}
