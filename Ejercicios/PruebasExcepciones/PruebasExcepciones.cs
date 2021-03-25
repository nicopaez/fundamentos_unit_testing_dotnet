using System;
using System.Collections;
using NUnit.Framework;

namespace PruebasExcepciones
{
    [TestFixture]
    public class PruebasExcepciones
    {
        [Test]
        public void DivisionPorCeroLanzaZeroDiviionError()
        {
            Func<int, int, int> dividir = (int dividendo, int divisor) => dividendo / divisor;
            Assert.Throws<DivideByZeroException>(() => dividir(1, 0));
        }

        [Test]
        public void AccesoFueraDeRangoLanzaIndexOutOfRangeException()
        {
            int[] items = new[] {1, 2};
            Assert.Throws<IndexOutOfRangeException>(() => items[3].ToString());
        }


        [Test]
        public void InvocarSobreUnMetodoDeUnaReferenciaQueEsNullLanzaNullReferenceException()
        {
            ArrayList arr = null;
            Assert.Throws<NullReferenceException>(() => arr.Clear());
        }
    }
}
