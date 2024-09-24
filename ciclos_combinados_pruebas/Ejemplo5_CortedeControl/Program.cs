using System;

namespace Ejemplo5_CortedeControl
{
    class Program
    {
        static void Main(string[] args)
        {
            string personaje, serie;
            int Nserie, edad, NserieAct=0;

            Console.WriteLine("Nombre de personaje: ");
            personaje= string.ParseShort(Console.ReadLine());
            Console.WriteLine("Nombre de serie: ");
            serie= string.ParseShort(Console.ReadLine());
            Console.WriteLine("Id serie: ");
            Nserie= int.Parse(Console.ReadLine());
            Console.WriteLine("Edad: ");
            edad= int.Parse(Console.ReadLine());
            //Id de serie (Nserie) es distinto de 0?
                while (Nserie!=0)
                {
                    //Asignacion Nserie para comparar y entrar al sublote
                    NserieAct=Nserie;
                        while (Nserie==NserieAct)
                        {
                            Console.WriteLine("Nombre de personaje: ");
                            personaje= string.ParseShort(Console.ReadLine());
                            Console.WriteLine("Nombre de serie: ");
                            serie= string.ParseShort(Console.ReadLine());
                            Console.WriteLine("Id serie: ");
                            Nserie= int.Parse(Console.ReadLine());
                            Console.WriteLine("Edad: ");
                            edad= int.Parse(Console.ReadLine());
                        }
                }
        }
    }
}
