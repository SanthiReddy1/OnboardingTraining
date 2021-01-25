using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitDemo
{
    [TestFixture]
    public class Base
    {
        [SetUp]
        public void SetUpMethod()
        {
            Console.WriteLine("SetUp Method");
        }
        [Test]
        //[Ignore("Ignoring TestMethod1")]
        [Category("Smoke")]
        [Explicit]
        public void TestMethod1()
        {
            Console.WriteLine("Test Method1");
            string fruit = "Apples";
            Assert.IsNotEmpty(fruit);
            Assert.IsNull(fruit, fruit + " is not null");
            Assert.AreEqual("Apple", fruit, fruit + " is not equal to Apple");
        }
        [Test]
        [Category("Regression")]
        public void TestMethod2()
        {
            Console.WriteLine("Test Method2");
        }

        [TearDown]
        public void TearDownMethod()
        {
            Console.WriteLine("TearDown Method");
        }        
    }
}
