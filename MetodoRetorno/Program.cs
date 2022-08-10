using System;


namespace MetodoRetorno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            int Dias;
            double pagoxdia;

            Console.WriteLine("Ingresa tu nombre: ");
            Nombre=Console.ReadLine();

            Console.WriteLine("Cuanto te pagan por día: ");
            pagoxdia = double.Parse(Console.ReadLine());

            Console.WriteLine("Cuantos días trabajas: ");
            Dias = int.Parse(Console.ReadLine());

            Console.WriteLine("El dinero obtenido por los días de trabajo es: " + CalcularTotal(pagoxdia, Dias));
            Console.ReadKey();
        }

        //Metodo total de dinero ganado

        static double CalcularTotal(double P1, int P2)
        {
            double Total;
            Total = (P1 * P2);
            return Total;
        }    
    }
}
