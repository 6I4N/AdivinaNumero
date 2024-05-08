using System.Diagnostics;

namespace Practicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intentos = 0;
            int respuesta;
            Random num = new Random();
            int numAleatorio = num.Next(0,100);

            Console.WriteLine("Adivine el número entre 0 a 100");
            do
            {
                respuesta = int.Parse(Console.ReadLine());
                intentos++;
                if (respuesta > numAleatorio) Console.WriteLine("El número es menor");

                else Console.WriteLine("El número es mayor");
            } while (respuesta != numAleatorio);

                Console.WriteLine($"Adivinaste el número|Número adivinado:{numAleatorio}|Intentos: {intentos}");
        }
    }
}
