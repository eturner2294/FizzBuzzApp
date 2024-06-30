using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Tests
{
    [TestClass()]
    public class FizzBuzzTests
    {
        [TestMethod()]
        public void FizzBuzzRuleIsSatisfiedTest()
        {
            var fizzBuzz = new FizzBuzz();
            bool result = fizzBuzz.ruleSatisfied(15);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void FizzBuzzRuleNotSatisfiedTest()
        {
            var fizzBuzz = new FizzBuzz();
            bool result = fizzBuzz.ruleSatisfied(2);

            Assert.IsFalse(result);

            result = fizzBuzz.ruleSatisfied(3);
            Assert.IsFalse(result);

            result = fizzBuzz.ruleSatisfied(5);
            Assert.IsFalse(result); 
        }
    }
}