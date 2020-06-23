using System;
using System.Collections.Generic;
using System.Text;

namespace ExXadrez.Tabuleiro.Except
{
    class TabuleiroException : Exception
    {
        public TabuleiroException(string msg) : base(msg)
        {
        }
    }
}
