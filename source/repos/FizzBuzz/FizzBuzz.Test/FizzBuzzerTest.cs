using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Test
    //Richard Felton
{
    [TestFixture]
    class FizzBuzzerTest
    {
        //    [Test]//Number 1
        //    public void Get_Returns_1_for_1()
        //    {
        //        var fizzBuzzer = new FizzBuzzer();

        //        var result = fizzBuzzer.Get(1);

        //        Assert.That(result, Is.EqualTo("1"));
        //    }
        //    [Test]//Number 2
        //    public void Get_Returns_2_for_2()
        //    {
        //        var fizzBuzzer = new FizzBuzzer();

        //        var result = fizzBuzzer.Get(2);

        //        Assert.That(result, Is.EqualTo("2"));
        //    }
        //    [Test]//Number 3 -- I expected Fizz, but I got 3
        //    public void Get_Returns_Fizz_for_3()
        //    {
        //        var fizzBuzzer = new FizzBuzzer();

        //        var result = fizzBuzzer.Get(3);

        //        Assert.That(result, Is.EqualTo("Fizz"));
        //    }

        //    [Test]//Number 4
        //    public void Get_Returns_Fizz_for_mul3()
        //    {
        //        var fizzBuzzer = new FizzBuzzer();

        //        var result = fizzBuzzer.Get(3);

        //        Assert.That(result, Is.EqualTo("Fizz"));
        //    }

        //    [Test]//Number 5; I wrote this test for 4
        //    public void Get_Returns_4_for_4()
        //    {
        //    var fizzBuzzer = new FizzBuzzer();

        //    var result = fizzBuzzer.Get(4);

        //    Assert.That(result, Is.EqualTo("4"));
        //     }

        //    [Test]//Number 6
        //    public void Get_Returns_Buzz_for_5()
        //    {
        //        var fizzBuzzer = new FizzBuzzer();

        //        var result = fizzBuzzer.Get(5);

        //        Assert.That(result, Is.EqualTo("Buzz"));
        //    }
        //    [Test]//Number 7
        //    public void Get_Returns_Buzz_for_10()
        //    {
        //        var fizzBuzzer = new FizzBuzzer();

        //        var result = fizzBuzzer.Get(10);

        //        Assert.That(result, Is.EqualTo("Buzz"));
        //    }
        [Test]//Number 8
        public void Get_Returns_FizzBuzz_for_15()
        {
            var fizzBuzzer = new FizzBuzzer();

            var result = fizzBuzzer.Get(15);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }
        //[Test]//Number 9
        //public void Get_Returns_FizzBuzz_for_30()
        //{
        //    var fizzBuzzer = new FizzBuzzer();

        //    var result = fizzBuzzer.Get(30);

        //    Assert.That(result, Is.EqualTo("FizzBuzz"));
        //}

        [Test]//Number 8
        public void Get_Returns_61_for_61()
        {
            var fizzBuzzer = new FizzBuzzer();

            var result = fizzBuzzer.Get(61);

            Assert.That(result, Is.EqualTo("61"));
        }

    }//class
}//namespace
