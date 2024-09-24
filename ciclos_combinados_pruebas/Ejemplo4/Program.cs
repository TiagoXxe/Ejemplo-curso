using System;

namespace Ejemplo4
{
    class Program
    {
        static void Main(string[] args)
        {
            //While con while
            int n;
            Console.WriteLine("Ingrese edad: ");
            n= int.Parse(Console.ReadLine());

            while (n>0)
            {
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
            Console.WriteLine("Ingrese edad para continuar o negativo para cortar ");
            n= int.Parse(Console.ReadLine());
            }
        }
    }
}
