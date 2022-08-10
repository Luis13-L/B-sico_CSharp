using System;


namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IngresoDato();
            Console.ReadKey();

        }

        //un metodo jejeje

        static void IngresoDato()
        {
            string Nombre;
            Console.WriteLine("Ingresa tu nombre: ");
            Nombre=Console.ReadLine();

            Console.WriteLine("Tu nombre es: "+Nombre);
        }
    }
}
