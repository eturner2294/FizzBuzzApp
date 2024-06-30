using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz : Rule
    {
        //If divisible by both 3 and 5, return true. 
        public bool ruleSatisfied(int val)
        {
            return val % 3 == 0 && val % 5 == 0; 
        }

        //print fizzbuzz
        public void doThing()
        {
            Console.WriteLine("Fizzbuzz");
        }
    }
}
