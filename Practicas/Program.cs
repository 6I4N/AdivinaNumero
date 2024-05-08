using System.Diagnostics;

namespace Practicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intentos = 1;
            Random num = new Random();
            int numAleatorio = num.Next(0,100);

            Console.WriteLine("Adivine el número entre 0 a 100");
            int respuesta = int.Parse(Console.ReadLine());

            while (respuesta != numAleatorio)
            {
                intentos++;
                
                if(respuesta > numAleatorio) Console.WriteLine("El número es menor");

                else Console.WriteLine("El número es mayor");

                respuesta = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Adivinaste el número|Número adivinado:{numAleatorio}|Intentos: {intentos}");
        }
    }
}
