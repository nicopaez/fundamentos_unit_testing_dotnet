using System;
using NUnit.Framework;

namespace Dominio.Tests
{
    [TestFixture]
    public class ExampleTest
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            Console.WriteLine("OneTimeSetUp");
        }

        [SetUp]
        public void SetUp()
        {
            Console.WriteLine("SetUp");
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine("Test1");
        }

        [Test]
        public void Test2()
        {
            Console.WriteLine("Test2");
        }
        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("TearDown");
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Console.WriteLine("OneTimeTearDown");
        }
    }
}
