using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace EjemplosVarios
{
    [TestFixture]
    public class CasosDePrueba
    {
        [Test]
        [TestCase(new int[] {3, 1, 2})]
        [TestCase(new int[] {1, 2, 3})]
        [TestCase(new int[] {7, 5, 1})]
        public void SortOrdenaElementos(int[] elementos)
        {
            var list = new List<int>(elementos);

            list.Sort();

            for (var i = 0; i < list.Count - 1; i++)
            {
                Assert.LessOrEqual(list[i], list[i+1]);
            }
        }

        [Test]
        [TestCase(new int[] {3, 1, 2}, 3)]
        [TestCase(new int[] {1, 2, 3}, 3)]
        [TestCase(new int[] {7, 5, 1}, 7)]
        public void SortOrdenaElementos(int[] elementos, int ultimo)
        {
            var list = new List<int>(elementos);

            list.Sort();

            Assert.AreEqual(ultimo, list[^1]);
        }
    }
}
