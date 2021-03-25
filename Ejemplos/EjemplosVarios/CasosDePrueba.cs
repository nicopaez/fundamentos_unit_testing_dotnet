using System.Collections.Generic;
using NUnit.Framework;

namespace EjemplosVarios
{
    [TestFixture]
    public class CasosDePrueba
    {
        [Test]
        public void SortOrdenaElementos()
        {
            var arr = new List<int>(new int[] {3, 1, 2});
            arr.Sort();
            for (var i = 0; i < arr.Count - 1; i++)
            {
                Assert.LessOrEqual(arr[i], arr[i+1]);
            }
        }

        [Test]
        [TestCase(new int[] {3, 1, 2})]
        [TestCase(new int[] {1, 2, 3, 4, 5})]
        [TestCase(new int[] {3, 5,37, 51, 1, 2})]
        public void SortOrdenaElementos(int[] elementos)
        {
            var arr = new List<int>(elementos);
            arr.Sort();
            for (var i = 0; i < arr.Count - 1; i++)
            {
                Assert.LessOrEqual(arr[i], arr[i+1]);
            }
        }

    }
}
