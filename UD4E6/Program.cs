using System;

namespace UD4E6
{
    class Program
    {
        static void Main(string[] args)
        {
            double precio = 50.5;

       
            String forma_de_pago = "tarjeta";

            if (forma_de_pago == "tarjeta")
            {
                Console.WriteLine("Introduce el numero de tarjeta");

                long numero_cuenta = 0045784248765;

                Console.WriteLine(value: $"Se ha realizado un pago de {precio} con tarjeta asociado al numero de cuenta {numero_cuenta}");
            }


            else if (forma_de_pago == ("efectivo"))
            {

                Console.WriteLine("Se ha relizado un pago de " + precio);

            }
            else
            {

                Console.WriteLine("La forma de pago no es correcta");
            }


            Console.ReadLine();
        }
    }
}
