using System;
using tabuleiro;

namespace xadrez_console
{
    public class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + "");

                for (int j = 0; j < tab.colunas; j++)
                {
                  imprimirPeca(tab.peca(i, j));
                  Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(" a b c d e f g h");
        }

        public static void imprimirTabuleiro(Tabuleiro tab, bool[,] posicoesPossiveis)
        {
          ConsoleColor fundoOriginal = Console.BackgroundColor;
          ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + "");

                for (int j = 0; j < tab.colunas; j++)
                {
                  if(posicoesPossiveis[i, j])
                  {
                    Console.BackgroundColor = fundoAlterado;
                  }
                  else
                  {
                    Console.BackgroundColor = fundoOriginal;
                  }
                  imprimirPeca(tab.peca(i, j));
                  Console.BackgroundColor = fundoOriginal;
                }
                Console.WriteLine();
            }
            Console.WriteLine(" a b c d e f g h");
            Console.BackgroundColor = fundoOriginal;
        }

        public static void imprimirPeca(Peca peca)
        {
            if (peca == null)
            {
              Console.Write("- ");
            }
            else
            {
              if (peca.cor == Cor.Branca)
              {
                Console.WriteLine(tab.peca(i, j));
              }
              else
              {
                ConsoleColor aux = Console.ForgroundColor;
                Console.ForgroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForgroundColor = aux;
              }
              Console.Write(" ");
            }
        }

        public static PosicaoXadrez lerPosicaoXadrez()
        {
          string s = Console.ReadLine();
          char coluna = s[0];
          int linha = int.Parse(s[1] + " ");
          return new PosicaoXadrez(coluna, linha);
        }
    }
}

