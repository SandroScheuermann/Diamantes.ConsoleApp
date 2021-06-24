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

            Console.Write("Digite a letra para construir o diamante : ");

            char letraSelecionada = Convert.ToChar(Console.ReadLine().ToUpper());
            Console.WriteLine();

            Console.WriteLine(construir.RetornaDiamante(letraSelecionada));
            Console.Read();
        }

    }
}