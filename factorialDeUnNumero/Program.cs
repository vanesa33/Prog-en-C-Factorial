using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace FACTORIAL_DE_UN_NÚMERO
{
    class Program
    {
        static void Main(string[] args)
        {
            byte NUM, K;
            long RESUL = 1;
            string linea;
            Console.Write("DIGITE UN NÚMERO: "); linea = Console.ReadLine();
            NUM = byte.Parse(linea);
            for (K = 2; K <= NUM; K++)
            {
                RESUL = RESUL * K;
            }
            Console.WriteLine("EL FACTORIAL ES: " + RESUL);
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
    }
}