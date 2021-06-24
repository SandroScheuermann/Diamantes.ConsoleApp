using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamantes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConstruirDiamante construir = new ConstruirDiamante();

            for (int i = 65; i <= 90; i++)
                Console.WriteLine(construir.PrintaDiamante((char)i));
            Console.Read();
        }

    }
}