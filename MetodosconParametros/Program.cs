using System;


namespace MetodosconParametros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Operacion;
            int NOperacion;
            Console.WriteLine("Sumar o Multilicar");
            Operacion = Console.ReadLine();
            Console.WriteLine("Que numero deseas trabajar: ");
            NOperacion = int.Parse(Console.ReadLine());

            if (Operacion == "Sumar")
            {
                Sumar(NOperacion);
            }
            else if (Operacion== "Multiplicar")
            {
                Multiplicar(NOperacion);
            }
            else
            {
                Console.WriteLine("No valido...");
            }
            Console.ReadKey();
        }


        //Metodo de suma

        static void Sumar(int Numero)
        {
            for(int i = 0; i <=12; i++)
            {
                Console.WriteLine(Numero + " + " + i + " = " + (Numero+i));

            }
        }

        //metodo multiplicar

        static void Multiplicar(int Numero)
        {

            for (int i = 0; i <= 12; i++)
            {
                Console.WriteLine(Numero + " X " + i + " = " + (Numero * i));

            }
        }

    }
}
