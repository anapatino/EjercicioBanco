using System;

namespace bancoPrimerEjercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primer ejemplo con Anya(clase,herencia,capas)");
            Cuenta cuenta = new CuentaAhorro(300000);
            //cuenta.Saldo = 200000;
            cuenta.Consignar(100000);
            Console.WriteLine($"-{cuenta.ConsultarSaldo()}");
            Console.ReadKey();
        }
    }
}
