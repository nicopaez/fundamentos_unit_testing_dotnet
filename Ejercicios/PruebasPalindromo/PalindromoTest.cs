using NUnit.Framework;

namespace PruebasPalindromo
{
    public class PalindromoTest
    {
        [Test]
        [TestCase("ana")]
        [TestCase("yo soy")]
        [TestCase("amar da drama")]
        public void EsPalindromo(string palabra)
        {
            Assert.True(Palindromo.EsPalindromo(palabra));
        }
    }
}
