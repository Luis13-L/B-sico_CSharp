using System;


namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Correlativo=0;
            Console.WriteLine("La tabla de 5");
            while (Correlativo<=12)
            {
                Console.WriteLine("5* " + Correlativo + "= " + (5 * Correlativo));
                Correlativo++;
            }
            Console.ReadKey();
        }
    }
}
