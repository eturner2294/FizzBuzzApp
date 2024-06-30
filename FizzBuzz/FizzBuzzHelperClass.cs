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

        //Loop through 0 - 100. 
        public void FizzBuzzHelper()
        {
            do
            {
                checkFizzBuzz(val);
                val++; 
            } while (val < 100);
        }

        //Check if each number satisfies the FizzBuzz, Fizz or Buzz rule.
        //If not, print the number. 
        private void checkFizzBuzz(int val)
        {
            FizzBuzz fizzbuzz = new FizzBuzz();
            Fizz fizz = new Fizz();
            Buzz buzz = new Buzz();

            if (fizzbuzz.ruleSatisfied(val))    //If a multiple of 3 and 5
            {
                fizzbuzz.doThing(); 
            }
            else if(fizz.ruleSatisfied(val)){   //If a multipe of 3
                fizz.doThing(); 
            }
            else if (buzz.ruleSatisfied(val))   //If a multiple of 5
            {
                buzz.doThing(); 
            }
            else {      //Else not a multipe of 3 or 5, so print the number
                Console.WriteLine(val); 
            }
        }
        //Not used, but if we wanted to reset the numbers and start again, do it here. 
        private void resetVal()
        {
            val = 0; 
        }
    }
}
