using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Buzz : Rule
    {
        //If divisible by 5, return true. 
        public bool ruleSatisfied(int val)
        {
            return val % 5 == 0; 
        }

        //print buzz
        public void doThing()
        {
            Console.WriteLine("Buzz");
        }
    }
}
