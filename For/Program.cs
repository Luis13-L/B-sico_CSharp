using System;


namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Nentero;
            Nentero = 0;
            Console.WriteLine("Ingrese un número para definir la tabla de sumar: ");
            Nentero=int.Parse(Console.ReadLine());

            for(int a=0; a<=12; a++)
            {
                Console.WriteLine(Nentero + "+ " + a + " = " + (Nentero + a));
            }
            Console.ReadKey();
        }
    }
}
