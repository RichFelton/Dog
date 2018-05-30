using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Test
{
    [TestFixture]
    class FizzBuzzerTest
    {
        [Test]
        public void Get_Returns_1_for_1()
        {
            var fizzBuzzer = new FizzBuzzer();

            var result = fizzBuzzer.Get(1);

            Assert.That(result, Is.EqualTo("1"));
        }
    }
}
