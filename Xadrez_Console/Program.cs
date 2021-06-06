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
        Tabuleiro tab = new Tabuleiro(8,8);  

        tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1,3));

        Tela.imprimirTabuleiro(tab);

        Console.ReadLine();
      }
      catch(TabuleiroException e)
      {
        throw new TabuleiroException(e.Message);
      }
    }
  }
}