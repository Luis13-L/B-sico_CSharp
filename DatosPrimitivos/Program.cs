using System;


namespace DatosPrimitivos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string Nombre;
            int Edad;
            const Double Sueldo=2050.33;
            dynamic Contedido;


            Contedido = 0.564;
            Nombre = "Luis";
            Edad = 22;
            
            Console.WriteLine("Contedino es: "+Contedido);    
            Console.WriteLine("Mi nombre es: "+Nombre + " y tengo "+Edad +" años " + ",actualmente tengo un sueldo de: "+Sueldo);
            Console.ReadKey();
        }
    } 
}
