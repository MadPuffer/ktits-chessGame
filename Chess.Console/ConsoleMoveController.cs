using Chess.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Console
{
    public class ConsoleMoveController : IMoveController<String>
    {
        public void Move(Piece<string> piece, string destCell)
        {
            // 64 - magic digit to cast char into int in correct form

            if (piece.IsRightMove(piece.Col, piece.Row, destCell[0] - 64, int.Parse(destCell[1].ToString())))
            {
                piece.Col = destCell[0] - 64;
                piece.Row = int.Parse(destCell[1].ToString());
                piece.Cell = destCell;
            }
        }
    }
}
