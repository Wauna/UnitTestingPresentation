using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Components;

namespace UnitTestComponents
{
    [TestClass]
    public class SubscriberTests
    {
        [TestMethod]
        public void SubscriberInstance()
        {
            //ARRANGE
            Subscriber sub = new Subscriber() {
                Name = new string('a', 35),
                Email = "Test@Test.com",
                Birthday = new DateTime(1977, 1, 1)
            };


            //ACT
            //** NOTHING TO DO YET

            //ASSERT
            Assert.AreEqual(sub.Name, new string('a',35));

            Assert.AreEqual(sub.Email, "Test@Test.com");

            Assert.AreEqual(sub.Birthday, new DateTime(1977, 1, 1));

        }

        [TestMethod]
        public void TestOver18() {
            //ARRANGE
            Subscriber sub = new Subscriber()
            {
                Name = new string('a', 35),
                Email = "Test@Test.com",
                Birthday =  DateTime.Now.AddYears(-18)
            };

            //ACT
            bool over18 = sub.IsOver18();
            
            //ASSERT
            Assert.IsTrue(over18);

        }

        [TestMethod]
        public void TestUnder18()
        {
            //ARRANGE
            Subscriber sub = new Subscriber()
            {
                Name = new string('a', 35),
                Email = "Test@Test.com",
                Birthday = DateTime.Now.AddYears(-3)
            };

            //ACT
            bool over18 = sub.IsOver18();

            //ASSERT
            Assert.IsFalse(over18);

        }



    }
}
