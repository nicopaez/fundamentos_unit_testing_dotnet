using System;
using System.Collections;
using NUnit.Framework;

namespace PruebasStack
{
    public class StackTest
    {
        [Test]
        public void UltimoEntradoPrimeroSalido()
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Assert.That(stack.Pop(), Is.EqualTo(3));
            Assert.That(stack.Pop(), Is.EqualTo(2));
            Assert.That(stack.Pop(), Is.EqualTo(1));
        }

        [Test]
        public void LanzaInvalidOperationExceptionAlSacarCuandoEstaVacio()
        {
            var stack = new Stack();
            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }

        [Test]
        public void SeCreaVacio()
        {
            var stack = new Stack();
            Assert.IsEmpty(stack);
        }
    }
}
