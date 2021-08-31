using System;

namespace CuentaBancaria
{
    /// <summary>
    /// Clase Cuenta Bancaria
    /// </summary>
    public class CuentaBancaria
    {
        private string numeroCuenta;
        private string nombreCliente;
        private double saldoCuenta;

        public CuentaBancaria(string cuenta, string cliente, double saldo)
        {
            numeroCuenta = cuenta;
            nombreCliente= cliente;
            saldoCuenta = saldo;
        }

        public string getNumeroCuenta
        {
            get { return numeroCuenta; }
        }

        public string getNombreCliente
        {
            get { return nombreCliente; }
        }

        public double getSaldoCuenta
        {
            get { return saldoCuenta; }
        }

        public void Deposito(double valor)
        {
            if (valor < 0)
            {
                throw new System.ArgumentOutOfRangeException("valor", valor, "El valor a depositar es menor a cero");
            }
                        
                saldoCuenta += valor;
        }

        public void Retiro(double valor)
        {
            if (valor > saldoCuenta)
            {
                throw new System.ArgumentOutOfRangeException("valor", valor, "El valor a retirar es mayor que el saldo actual de la cuenta");
            }

            if (valor < 0)
            {
                throw new System.ArgumentOutOfRangeException("valor", valor, "El valor a retirar es menor a cero");
            }

            saldoCuenta -= valor;
        }

        public static void Main()
        {
            CuentaBancaria miCuenta = new CuentaBancaria("1010","Pepito Pérez", 0);

            miCuenta.Deposito(80000);
            Console.WriteLine("El saldo actual de la cuenta del señor {0} es ${1}", miCuenta.nombreCliente, miCuenta.saldoCuenta);



        }
    }
}
