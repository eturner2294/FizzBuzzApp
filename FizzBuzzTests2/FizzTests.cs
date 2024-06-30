using NUnit; 
using FizzBuzz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Tests
{
    [TestClass()]
    public class FizzTests
    {
        public void FizzRuleIsSatisfiedTest()
        {
            var Fizz = new Fizz();
            bool result = Fizz.ruleSatisfied(3);
            Assert.IsTrue(result);

            result = Fizz.ruleSatisfied(6);
            Assert.IsTrue(result); 
        }

        public void ruleIsNotSatisfied()
        {
            var Fizz = new Fizz();
            bool result = Fizz.ruleSatisfied(5);
            Assert.IsFalse(result); 
        }
    }
}