using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class FabonacciSeries
    {
        public static void fabseries()
        {
            int len;
            len=int.Parse(Console.ReadLine());
            int var1 = 0, var2 = 1, var3 = 0;
            Console.WriteLine(" {0} {1} ",var1,var2);
            for (int i = 0; i < len; i++)
            {
                var3 = var1 + var2;
                Console.WriteLine(" " + var3);
                var1 = var2;
                var2 = var3;
            }

        }
    }
}
