using System;
using NUnit.Framework;

namespace EjemplosVarios
{
    [TestFixture]
    public class Orden
    {
        [Test, Order(2)]
        [Category("Ejemplos")]
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
