using System;


namespace OperadoresRelacionales
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int Num1, Num2;
            Boolean Operaciones;
            Num1 = 10;
            Num2 = 11;
            Operaciones = Num1 != Num2;

            Console.WriteLine("Num1 es mayor o igual que Num2? "+ Operaciones);
            Console.ReadKey();
        }
    }
}
