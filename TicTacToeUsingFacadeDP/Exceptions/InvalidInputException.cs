using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeUsingFacadeDP.Exceptions
{
    internal class InvalidInputException : Exception
    {
        // Exception for Invalid Input...
        public InvalidInputException(string message) : base(message) { }
    }
}
