using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamantes.ConsoleApp
{
    public class ConstruirDiamante
    {
        public string PrintaDiamante(char letra)
        {
            int diferencaLetras = (int)letra - 65;
            string espacoEsquerda = "";
            string espacoMeio = " ";
            string diamante = "";

            for (int i = diferencaLetras; i > 0; i--)
                espacoEsquerda += " ";

            for (int i = 65; i <= letra; i++)
            {
                if (i == 65)
                {
                    diamante += espacoEsquerda + (char)i + "\n";
                    continue;
                }
                espacoEsquerda = espacoEsquerda.Substring(0, espacoEsquerda.Length - 1);
                diamante += espacoEsquerda + (char)i + espacoMeio + (char)i + "\n";
                espacoMeio += "  ";
            }

            if (espacoMeio.Length > 2)
                espacoMeio = espacoMeio.Substring(0, espacoMeio.Length - 2);

            for (int j = (int)letra - 1; j >= 65; j--)
            {
                if (j == 65)
                {
                    espacoEsquerda += " ";
                    diamante += espacoEsquerda + (char)j + "\n";
                    continue;
                }
                espacoEsquerda += " ";

                if (espacoMeio.Length == 1)
                {
                    espacoMeio = "";
                    continue;
                }
                espacoMeio = espacoMeio.Substring(0, espacoMeio.Length - 2);
                diamante += espacoEsquerda + (char)j + espacoMeio + (char)j + "\n";
            }

            return diamante;
        }

    }
}
