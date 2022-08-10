using System;


namespace OperadoresLogicos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a, b, c, d;
            bool Resultado;
            a = 10;
            b = 2;
            c = 0;
            d = 205;

            Resultado = !(b>c);

            Console.WriteLine("Resultado de (a==b) && (c>d) " + Resultado);
            Console.ReadKey();
        }
    }
}
