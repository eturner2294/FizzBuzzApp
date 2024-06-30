using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public class BuzzTests
    {
        public void BuzzRuleIsSatisfiedTest()
        {
            var buzz = new Buzz();
            Assert.IsTrue(buzz.ruleSatisfied(5));
            Assert.IsTrue(buzz.ruleSatisfied(10));
            Assert.IsTrue(buzz.ruleSatisfied(50)); 
        }

        public void BuzzRuleIsNotSatisfiedTest()
        {
            var buzz = new Buzz();
            Assert.IsFalse(buzz.ruleSatisfied(3));
            Assert.IsFalse(buzz.ruleSatisfied(2));
        }
    }
}