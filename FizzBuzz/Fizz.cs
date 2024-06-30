using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Fizz : Rule
    {
        //If divisible by 3, return true.
        public bool ruleSatisfied(int val)
        {
            return val % 3 == 0; 
        }

        //Print fizz
        public void doThing()
        {
            Console.WriteLine("Fizz"); 
        }
    }
}
