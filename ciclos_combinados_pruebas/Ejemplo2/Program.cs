using System;

namespace Ejemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //for con while
            int n;
            for (int i = 0; i < 3; i++)
            {
            Console.WriteLine("Ingrese numero: ");
            n= int.Parse(Console.ReadLine());

            int acu=0,prom=0, con=0;

                while (n!=0)
                {
                    Console.WriteLine("Ingrese edad: ");
                    n= int.Parse(Console.ReadLine());
                    acu+=n;
                    con++;
                }
                prom= acu/con;
                Console.WriteLine("Promedio: " + prom);
            }   
        }
    }
}
