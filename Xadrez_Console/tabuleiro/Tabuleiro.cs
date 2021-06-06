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

        public Peca peca(int linnha, int coluna)
        {
          return peca[linha,coluna];
        }

        public void colocarPeca(Peca p, Peca pos)
        {
          peca[pos.linha, pos.coluna] = p;
          p.posicao = pos; 
        }
    }
}
