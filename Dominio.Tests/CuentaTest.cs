using NUnit.Framework;

namespace Dominio.Tests
{
    public class CuentaTest
    {
        [Test]
        public void SeCreaConSaldoCero()
        {
            var titular = new Persona("Juan");

            var cuenta = new Cuenta(titular);

            Assert.AreEqual(0, cuenta.Saldo);
        }

        [Test]
        public void AcreditarIncrementaElSaldo()
        {
            var titular = new Persona("Juan");
            var cuenta = new Cuenta(titular);
            var monto = 10;

            cuenta.Acreditar(monto);

            Assert.AreEqual(monto, cuenta.Saldo);
        }

        [Test]
        public void AcreditarUnMontoNegativoEsUnaOperacionNoValida()
        {
            var titular = new Persona("Juan");
            var cuenta = new Cuenta(titular);
            var montoNegativo = -10;

            Assert.Catch<OperacionNoValidaException>(() => cuenta.Acreditar(montoNegativo));
        }

        [Test]
        public void DebitarDecrementaElSaldo()
        {
            var titular = new Persona("Juan");
            var cuenta = new Cuenta(titular);
            var monto = 10;

            cuenta.Debitar(monto);

            Assert.AreEqual(-monto, cuenta.Saldo);
        }
    }
}
