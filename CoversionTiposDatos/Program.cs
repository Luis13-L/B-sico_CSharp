using System;


namespace CoversionTiposDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String Nombre;
            int Edad;
            bool Casado;
            double Sueldo;

            Console.WriteLine("Ingrese su nombre: ");
            Nombre = Console.ReadLine();


            Console.WriteLine("Ingrese su edad: ");
            //Edad = int.Parse(Console.ReadLine());
            Edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Eres Casado? ");
            //Casado = bool.Parse(Console.ReadLine());
            Casado = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Tu sueldo es: ");
            //Sueldo = double.Parse(Console.ReadLine());
            Sueldo = Convert.ToDouble(Console.ReadLine());

            Console.ReadKey();


        }
    }
}
