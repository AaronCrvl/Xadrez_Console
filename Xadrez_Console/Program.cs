using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        PartidaDeXadrez partida = new PartidaDeXadrez();
        while(!partida.terminada)
        {
          Console.Clear();
          Tela.imprimirTabuleiro(partida.tab);

          Console.WriteLine();
          Console.Write("Origem: ");
          Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

          bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

          Console.Clear();
          Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

          Console.Write("Destino: ");
          Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
          
          partida.executaMovimento(origem, destino);
        }
      }
      catch(TabuleiroException e)
      {
        throw new TabuleiroException(e.Message);
      }

      /*
      try
      {
        PosicaoXadrez pos = new PosicaoXadrez('a',1);
        PosicaoXadrez pos2 = new PosicaoXadrez('c',7);

        Console.WriteLine(pos);
        Console.WriteLine(pos.toPosicao());

        Console.WriteLine(pos2);
        Console.WriteLine(pos2.toPosicao());

        Console.ReadLine();
      }
      catch(Exception e)
      {
        return "Falha em caso teste" + e.Message;
      }
      */
      
    }
  }
}