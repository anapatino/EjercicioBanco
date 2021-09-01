using System;


namespace bancoPrimerEjercicio
{
    public class CuentaCorriente : Cuenta
    {
        //public CuentaCorriente(decimal monto):base(monto)
        //{
        //    Console.WriteLine(" Ha ingresado a la cuenta corriente");

        //}
        private decimal cupo;
        public CuentaCorriente(decimal cupo,decimal saldo)
        {

        }
        public override void Consignar(decimal valor)
        {
            throw new NotImplementedException();
        }

        public override void Retirar(decimal valor)
        {
            throw new NotImplementedException();
        }
    }
}
