using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancoPrimerEjercicio
{
    public abstract class Cuenta
    {
        //ctor tabular tabular
        //public Cuenta(decimal monto)
        //{
        //    saldo = monto;
        //}

        protected decimal saldo;

        public abstract void  Consignar(decimal valor);
        //{
        //    saldo += valor;
        //}
        public abstract void Retirar(decimal valor);
        //{
        //    saldo -= valor;
        //}
        public string ConsultarSaldo()
        {
            return $"Su saldo es {saldo}";
        }
    }
}
