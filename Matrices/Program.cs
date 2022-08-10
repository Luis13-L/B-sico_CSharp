using System;


namespace Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[,] Persona = new string[3, 2];

            Persona[0, 0] = "Luis";
            Persona[0, 1] = "Tautiu";
            Persona[1, 0] = "Marta";
            Persona[1, 1] = "Jorge";
            Persona[2, 0] = "Gómez";
            Persona[2, 1] = "Lucía";

            for (int i = 0; i < 3; i++)
            {
               Console.WriteLine("Persona [" + i + "] = " + Persona[i,0] + " " + Persona[i,1]);
               
            }
            Console.ReadKey();
        }
    }
}
