using System;


namespace CondicionIf
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String Nombre;
            Double Sueldo;

            Console.WriteLine("Ingresa tu nombre: ");
            Nombre= Console.ReadLine();

            Console.WriteLine("Ingresa tu sueldo: ");
            Sueldo = double.Parse(Console.ReadLine());

            // El sueldo minimo de guate es Q. 3100.00
            // El sueldo ingresado es mayor a Q. 3500
            if(Sueldo <= 3100)
            {
                Console.WriteLine(Nombre + ", Tu sueldo es el mínimo");
            }else if(Sueldo > 3100 && Sueldo <= 3500)
            {
                Console.WriteLine("Tu sueldo está bien");
            }else if(Sueldo > 3500)
            {
                Console.WriteLine("Vas a ser millonario");
            }
            
            Console.ReadLine();
        }
    }
}
