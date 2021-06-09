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
      /*try
      {
        Tabuleiro tab = new Tabuleiro(8,8);  

        tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1,3));

        Tela.imprimirTabuleiro(tab);

        Console.ReadLine();
      }
      catch(TabuleiroException e)
      {
        throw new TabuleiroException(e.Message);
      }*/

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
      
    }
  }
}