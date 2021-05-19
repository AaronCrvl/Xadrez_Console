using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public Tabuleiro tab { get; protected set; }
        public int qtdMovimentos { get; protected set; }

        Peca(Posicao _pos, Cor _cor, Tabuleiro _tab ) 
        {
            this.posicao = _pos;
            this.cor = _cor;
            this.tab = _tab;
            this.qtdMovimentos = 0;
        }
    }
}
