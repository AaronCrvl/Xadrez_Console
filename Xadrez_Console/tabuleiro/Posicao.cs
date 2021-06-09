using System;

namespace tabuleiro
{
    class Posicao
    {
       //Dados:
        public int linha { get; set;  }
        public int coluna { get; set; }

        //Construtor
        Posicao(int _linha, int _coluna ) 
        {
            this.linha = _linha;
            this.coluna = _coluna;
        }

        //Métodos:
        public override string ToString()
        {
            // Quando objeto da classe é criado e jogado para o output é tratado da forma abaixo:
            return this.linha
                + ","
                + this.coluna;
        }
    }
}
