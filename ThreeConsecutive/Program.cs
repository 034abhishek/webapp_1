using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeConsecutive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 1,2,3,4,5,};
            Consecutive(array);
            Console.ReadLine();
        }

        private static int Consecutive(int[] arr)
        {
            for(int i=0;i<arr.Length-2;i++)
            {
                if ((arr[i] + 1) == arr[i + 1] && (arr[i + 1] + 1) == arr[i + 2])
                    Console.WriteLine("{0},{1},{2}",arr[i], arr[i+1], arr[i+2]);
                
            }

            return 0;
        }
    }
}
