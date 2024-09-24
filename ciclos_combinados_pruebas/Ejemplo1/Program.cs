using System;

namespace Ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
           //for con for 
            for (int i = 0; i < 3; i++)
            {
            int acu=0,prom=0;

                for (int x=0; x<5; x++)
                {
                    Console.WriteLine("Ingrese edad: ");
                    n= int.Parse(Console.ReadLine());
                    acu+=n;
                }
                prom= acu/5;
                Console.WriteLine("Promedio: " + prom);
            }      
        }
    }
}
