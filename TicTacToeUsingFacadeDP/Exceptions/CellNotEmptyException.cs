using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeUsingFacadeDP.Exceptions
{
    internal class CellNotEmptyException : Exception
    {
        public CellNotEmptyException(string message):base(message) { }
    }
}
