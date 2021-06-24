using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Diamantes.ConsoleApp;

namespace Diamantes.Testes
{
    [TestClass]
    public class UnitTest1
    {
        ConstruirDiamante construir = new ConstruirDiamante();

        [TestMethod]
        public void DeveRetornarDiamanteZ()
        {
            string valorEsperado =
                "                         A\n" +
                "                        B B\n" +
                "                       C   C\n" +
                "                      D     D\n" +
                "                     E       E\n" +
                "                    F         F\n" +
                "                   G           G\n" +
                "                  H             H\n" +
                "                 I               I\n" +
                "                J                 J\n" +
                "               K                   K\n" +
                "              L                     L\n" +
                "             M                       M\n " +
                 "           N                         N\n" +
                "           O                           O\n" +
                "          P                             P\n" +
                "         Q                               Q\n" +
                "        R                                 R\n" +
                "       S                                   S\n" +
                "      T                                     T\n" +
                "     U                                       U\n" +
                "    V                                         V\n" +
                "   W                                           W\n" +
                "  X                                             X\n" +
                " Y                                               Y\n" +
                "Z                                                 Z\n" +
                " Y                                               Y\n" +
                "  X                                             X\n" +
                "   W                                           W\n" +
                "    V                                         V\n" +
                "     U                                       U\n" +
                "      T                                     T\n" +
                "       S                                   S\n" +
                "        R                                 R\n" +
                "         Q                               Q\n" +
                "          P                             P\n" +
                "           O                           O\n" +
                "            N                         N\n" +
                "             M                       M\n" +
                "              L                     L\n" +
                "               K                   K\n" +
                "                J                 J\n" +
                "                 I               I\n" +
                "                  H             H\n" +
                "                   G           G\n" +
                "                    F         F\n" +
                "                     E       E\n" +
                "                      D     D\n" +
                "                       C   C\n" +
                "                        B B\n" +
                "                         A\n";

            Assert.AreEqual(construir.RetornaDiamante('Z'), valorEsperado);

        }
        [TestMethod]
        public void DeveRetornarDiamanteE()
        {

            string valorEsperado =
                "    A\n" +
                "   B B\n" +
                "  C   C\n" +
                " D     D\n" +
                "E       E\n" +
                " D     D\n" +
                "  C   C\n" +
                "   B B\n" +
                "    A\n";

            Assert.AreEqual(construir.RetornaDiamante('E'), valorEsperado);

        }
        [TestMethod]
        public void DeveRetornarDiamanteC()
        {

            string valorEsperado =
                "  A\n" +
                " B B\n" +
                "C   C\n" +
                " B B\n" +
                "  A\n";

            Assert.AreEqual(construir.RetornaDiamante('C'), valorEsperado);

        }
        [TestMethod]
        public void DeveRetornarDiamanteA()
        {
            string valorEsperado = "A\n";
            Assert.AreEqual(construir.RetornaDiamante('A'), valorEsperado);
        }

    }
}
