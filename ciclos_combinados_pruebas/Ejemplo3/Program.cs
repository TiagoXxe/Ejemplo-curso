using System;

namespace Ejemplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            //while con for
            int n;
            Console.WriteLine("Ingrese 1 para comenzar o 0 para terminar: ");
            n= int.Parse(Console.ReadLine());

            while (n!=0)
            {
            int acu=0,prom=0, con=0;

                for (int x=0; x<5; x++)
                {
                    Console.WriteLine("Ingrese edad: ");
                    n= int.Parse(Console.ReadLine());
                    acu+=n;
                    con++;
                }
                prom= acu/con;
                Console.WriteLine("Promedio: " + prom);
            Console.WriteLine("Ingrese 1 para continuar o 0 para terminar: ");
            n= int.Parse(Console.ReadLine());
            }
        }
    }
}
