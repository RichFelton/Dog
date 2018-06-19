using NUnit.Framework;

namespace ArraysHomework
    //Richard Felton
{
    [TestFixture]
    public class ArraysTests
    {
        // Whenever you see this constant, you'll need to delete the
        // variable reference and replace it with a literal value.
        const object __FILL_ME_IN__ = null;

        [Test]//Number 1
        public void Array_Length_Is_EqualTo_Size()
        {
            var array = new int[3];

            // Replace __FILL_ME_IN__ with the correct value.
            Assert.That(array.Length, Is.EqualTo(3));
        }

        [Test]//Number 2
        public void Arrays_Can_Be_Initialized_With_Items()
        {
            var array = new string[3]  {"car", "plane", "bicycle"} ;

            Assert.That(array, Is.Not.All.Null);
        }

        [Test]//Number 3
        public void Arrays_Use_Zero_Based_Indexes()
        {
            var array = new string[3] { "Foo", "Bar", "Baz" };

            string valueAtIndex1 = array[1];

            Assert.That(valueAtIndex1, Is.EqualTo("Bar"));
        }

        //[Test]//Number 4
        public void Arrays_Allow_You_To_Get_Values_With_Indexers()
        {
            var array = new string[3] { "Foo", "Bar", "Baz" };

            // What value does array[2] return?
            Assert.That(array[2], Is.EqualTo("Bar"));
        }

        //[Test]//Number 5
        public void Arrays_Allow_You_To_Set_Values_With_Indexers()
        {
            var array = new string[3] { "Foo", "Bar", "Baz" };

            //    // Use an indexer (square brackets) to change "Bar" to "Quux".

            CollectionAssert.AreEqual(array, new string[3] { "Foo", "Quux", "Baz" });
        }

    }
}
