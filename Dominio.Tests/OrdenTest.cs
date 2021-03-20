using System;
using NUnit.Framework;

namespace Dominio.Tests
{
    [TestFixture]
    public class OrdenTest
    {
        [Test, Order(2)]
        public void Test1()
        {
            Console.WriteLine("Test1");
        }

        [Test, Order(1)]
        public void Test2()
        {
            Console.WriteLine("Test2");
        }
    }
}
