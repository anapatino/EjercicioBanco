using System;


namespace bancoPrimerEjercicio
{
    class CuentaAhorro:Cuenta
    {
        public CuentaAhorro(decimal monto)//:base(monto)
        {
            Console.WriteLine(" Ha ingresado a la cuenta de ahorros");
        }

        public override void Consignar(decimal valor)
        {
            saldo+= valor;
        }

        public override void Retirar(decimal valor)
        {
            saldo -= valor;
        }
    }
}
