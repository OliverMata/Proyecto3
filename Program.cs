using System;

namespace Proyecto3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que muestre los primeros 10 números pares a partir del producto de (10 x 10).
            for (int i = 100; i <= 120; i=i+2)
            {
                Console.WriteLine("Los 10 primeros numeros pares despues de multiplicar 10 por 10");
                Console.WriteLine(i);
            }
            Console.Read();
            
        }
    }
}
