using System;

namespace tabuleiro
{
  class TabuleiroException : Exception
  {
    public TabuleiroException(string msg) : base(string msg){}
  }
}