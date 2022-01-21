using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class PrimeNumber
    {
        public int number { get; set; }
        public PrimeNumber() { }
        public PrimeNumber(int number)
        {
            this.number = number;
            Console.WriteLine("enter number " + this.number);
            if (this.number != 1 && this.number > 2)
            {
                for (int i = 2; i <= (this.number / 2); i++)
                {
                    if (this.number % i == 0)
                    {
                        Console.WriteLine("number is not prime " + this.number);
                    }
                }
            }
            Console.WriteLine("Number is primenumber" + this.number);
        }
    }
}
