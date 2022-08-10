using System;


namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int Día;
            Console.WriteLine("Ingrese el día en numero: ");
            Día=int.Parse(Console.ReadLine());

            switch (Día)
            {
               
                case 1:
                    Console.WriteLine("Es lunes");
                    break;
                case 2:
                    Console.WriteLine("Es Maartes");
                    break;

                case 3:
                    Console.WriteLine("Es Miercoles");
                    break;

                case 4:
                    Console.WriteLine("Es Jueves");
                    break;
                case 5:
                    Console.WriteLine("Es viernes");
                    break;

                case 6:
                    Console.WriteLine("Es sabado");
                    break;
                case 7:
                    Console.WriteLine("Es Domingo");
                    break;
                    default: Console.WriteLine("No es un día");
                    break;
            }
            Console.ReadKey();
        }
    }
}
