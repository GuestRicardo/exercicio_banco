using System;
using System.Globalization;

namespace ContaBancaria
{
	class Class1
	{
        public int Numero { get; private set; }
        public int Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = 0.0;
        }

        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular, saldo)
        {
            Saldo = saldo;
        }
        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular"
                + Titular
                + ", Saldo: R$ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
                
        }
    }

}

