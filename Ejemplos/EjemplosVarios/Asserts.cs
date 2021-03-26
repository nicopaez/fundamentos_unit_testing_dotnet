using System.Collections;
using NUnit.Framework;

namespace EjemplosVarios
{
    [TestFixture]
    public class Asserts
    {

        [Test]
        public void ArrayListSeCreaVacio()
        {
            var array = new ArrayList();
            Assert.IsEmpty(array);
        }

        [Test]
        public void ArrayListContineItem()
        {
            var array = new ArrayList(new int[]{1, 2});
            Assert.Contains(1, array);
        }

        [Test]
        public void StringHolaNoEsVacio()
        {
            var hola = "hola";
            Assert.That(hola, Is.Not.Empty);
        }

        [Test]
        public void StringHolaTieneLongitud4()
        {
            var hola = "hola";
            Assert.That(hola.Length, Is.EqualTo(4));
        }

        [Test]
        public void StringHolaContieneH()
        {
            var hola = "hola";
            Assert.That(hola.Contains('h'));
        }
    }
}
