using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class Reversenumber
    {
        public static string finalrev { get; private set; }

        public static void reverseNum()
        {
            string numInStr = Console.ReadLine();
            int singleDigit = 0;
            int reverseNum = 0;
            int numInInt = Convert.ToInt32(numInStr);
            Console.WriteLine("Number to be reverse is " + numInInt);

            while (numInInt > 0)
            {
                singleDigit = numInInt % 10; //get remainder
                reverseNum = (reverseNum * 10) + singleDigit;
                numInInt = numInInt / 10;
            }
            Console.WriteLine("Reversed number is  " + reverseNum);
        }
    }
}
