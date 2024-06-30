using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class FizzBuzzHelperClass
    {
        int val = 0;

        public void FizzBuzzHelper()
        {
            do
            {
                if (val % 3 == 0 && val % 5 == 0)
                {
                    Console.WriteLine("Fizzbuzz"); 
                } else if(val % 3 == 0)
                {

                    Console.WriteLine("Fizz"); 
                } else if(val % 5 == 0)
                {
                    Console.WriteLine("Buzz"); 
                }
                else
                {
                    Console.WriteLine(val);
                }
                val++; 
            } while (val < 100);
        }


        private void resetVal()
        {
            val = 0; 
        }
    }
}
