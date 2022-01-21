using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class Primenum2
    {
        public static void primeNum()
        {
            string numInString;
           // int numInInt;
            numInString = Console.ReadLine();
            int numInInt = Convert.ToInt32(numInString);
            Console.WriteLine("to check number is " + numInString);
            if (numInInt != 1 && numInInt > 2)
            {
                for (int i = 2; i <= (numInInt / 2); i++)
                {
                    if (numInInt % i == 0) 
                    {
                        Console.WriteLine("number is not prime " + numInInt);
                    }
                }

            }
            Console.WriteLine("Number is primenumber" + numInInt);

        }
    }
}

