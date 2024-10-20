using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeUsingFacadeDP.Types;

namespace TicTacToeUsingFacadeDP.Models
{
    internal class Cell
    {
        public MarkType Mark {  get; set; }

        public Cell() 
        { 
            Mark = MarkType.EMPTY;
        }

        public bool IsEmpty()
        {
            return Mark == MarkType.EMPTY;
        }
    }
}
