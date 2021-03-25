using System;
using NUnit.Framework;

namespace Dominio.Tests
{
    [TestFixture]
    public class ResultadoTest
    {
        [Test]
        public void TestQuePasa()
        {
            Console.Write("ok");
        }

        [Test]
        public void TestQueFalla()
        {
            var valor = 5;
            // Assert.AreEqual(4, valor);
        }

        [Test]
        public void TestInconcluso()
        {
            Assert.Inconclusive();
        }

        [Test, Ignore("Desactivado temporalmente por ....")]
        public void TestIgnorado()
        {
            Assert.Ignore();
        }

    }
}
