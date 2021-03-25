using System;

namespace Dominio
{
    public class Cuenta
    {
        private Persona titular;

        public Cuenta(Persona titular)
        {
            this.titular = titular;
        }

        public double Saldo { get; private set; }

        public void Acreditar(double monto)
        {
            if (monto < 0)
            {
                throw new OperacionNoValidaException();
            }
            this.Saldo += monto;
        }

        public void Debitar(double monto)
        {
            this.Saldo -= monto;
        }
    }
}
