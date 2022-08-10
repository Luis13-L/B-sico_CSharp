using System;


namespace Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] Nombres = { "Willy", "Wilson", "Marta", "Luis", "Yonny" };
            for(int i = 0; i < Nombres.Length; i++)
            {
                Console.WriteLine("El nombre del indice "+i +" es igual a: "+Nombres[i]);
            }
            Console.WriteLine("El tamaño de tu vector es igual a: "+Nombres.Length);
            Console.ReadKey();
        }
    }
}
