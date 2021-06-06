using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xadre;

namespace xadrez_console
{
  class Program
  {
    static void Main(string[] args)
    {
      Tabuleiro tab = new Tabuleiro(8,8);  

      tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1,3));

      Tela.imprimirTabuleiro(tab);

      Console.ReadLine();
    }
  }
}