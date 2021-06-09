namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int _linhas, int _colunas)
        {
            this.linhas = _linhas;
            this.colunas = _colunas;
            pecas = new Peca[this.linhas, this.colunas];
        }

        public Peca peca(Posicao pos)
        {
            return pecas[pos.linhas, pos.coluna];
        }

        public Peca peca(int lnnha, int coluna)
        {
            return peca[linha, coluna];
        }

        public void colocarPeca(Peca p, Peca pos)
        {

            if (existePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nesta posição!");
            }
            peca[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

        public Peca retirarPeca(Posicao pos)
        {
          if(peca(pos) == null)
          {
            return null;
          }
          else
          {
            Peca aux = peca(pos);
            aux.posicao = null;
            pecas[pos.linha, pos.coluna] = null;
            return aux;
          }
        }


        public bool existePeca(Posicao pos)
        {
            validaPosicao(pos);
            return peca(pos) != null;
        }

        public bool posicaoValida(Posicao pos)
        {
            if (pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.colunas >= colunas)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void validaPosicao(Posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição Inválida.");
            }
        }
    }
}
