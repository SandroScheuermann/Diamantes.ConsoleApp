namespace Diamantes.ConsoleApp
{
    public class ConstruirDiamante
    {
        string espacoEsquerda = "";
        string espacoMeio = " ";
        string diamante = "";

        public string RetornaDiamante(char letra)
        {
            ObterEspacosDaMargem(letra);
            MontaParteDeCima(letra);
            MontaParteDeBaixo(letra);
            return diamante;
        }
        private void ObterEspacosDaMargem(char letra)
        {
            for (int i = letra - 'A'; i > 0; i--)
                espacoEsquerda += " ";
        }
        private void MontaParteDeBaixo(char letra)
        {
            for (int j = letra - 1; j >= 'A'; j--)
            {
                if (j == 'A')
                {
                    espacoEsquerda += " ";
                    diamante += espacoEsquerda + (char)j + "\n";
                    continue;
                }
                espacoEsquerda += " ";
                espacoMeio = espacoMeio.Substring(0, espacoMeio.Length - 2);
                diamante += espacoEsquerda + (char)j + espacoMeio + (char)j + "\n";
            }
        }
        private void MontaParteDeCima(char letra)
        {
            for (int i = 'A'; i <= letra; i++)
            {
                if (i == 'A')
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
        }
    }
}
