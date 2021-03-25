using System;
using NUnit.Framework;

namespace Dominio.Tests
{
    public class CuentaTest
    {
        private Cuenta cuenta;

        [SetUp]
        public void SetUp()
        {
            var titular = new Persona("Juan");
            this.cuenta = new Cuenta(titular);
        }

        [Test]
        [Category("Ejemplos")]
        public void AcreditarUnMontoNegativoNoEsValido()
        {
            var montoNegativo = -10;

            Assert.Throws<OperacionNoValidaException>(() => this.cuenta.Acreditar(montoNegativo));
        }

        [Test]
        public void SeCreaConSaldoCero()
        {
            Assert.AreEqual(0, cuenta.Saldo);
        }

        [Test]
        public void DebitarDecrementaElSaldo()
        {
            var monto = 10;
            var saldoFinalEsperado = this.cuenta.Saldo - monto;

            this.cuenta.Debitar(monto);

            Assert.AreEqual(saldoFinalEsperado, this.cuenta.Saldo);
        }
    }
}
