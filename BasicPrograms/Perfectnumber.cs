using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class Perfectnumber
    { 
        public static void perfectNumber()
        {
            int addition = 0 , number,num;
            Console.WriteLine("enter number");
            number = int.Parse(Console.ReadLine());
            num = number;
            for (int i=1; i<number; i++)
            {
                if ( number % i == 0)
                {
                    addition +=i;
                }
                
            }
            if (addition == num)
            {
                Console.WriteLine(" " + num + "number is perfect number ");
            }
            else
            {
                Console.WriteLine(" " + num + "number is not perfect number ");

            }
        }
    }
}
