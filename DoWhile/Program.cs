using System;


namespace DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int Numero;
            Numero = 0;

            do
            {

                Console.WriteLine("El valor de la variable es: " + Numero);
                Numero++;

            }while (Numero <= 10);
            Console.ReadKey();
        }
    }
}
