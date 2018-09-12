using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excel
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = { "A", "B", "c" };

            getExcelColumnNumber(str);
            
        }

        private static int getExcelColumnNumber(string[] colName)
        {
            int count = 0;
            for(int i = 0; i < colName.Length; i++)
            {
                int output = (int)(Math.Pow(26, count));
            }
            return 0;
        }
    }
}
