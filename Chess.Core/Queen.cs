/*
 * Chess-3
 * Kotdusov B.M. 220
 * 13.04.22
 */

using System;

namespace Chess.Core
{
    public class Queen<TCell> : Piece<TCell>
    {
        public Queen(char col, int row, TCell cell, IMoveController<TCell> controller) : base(col, row, cell, controller)
        {
            Name = "Queen";
        }

        public Queen(string pos, TCell cell, IMoveController<TCell> controller) : base(pos, cell, controller)
        {
            Name = "Queen";
        }

        public Queen(int col, int row, TCell cell, IMoveController<TCell> controller) : base(col, row, cell, controller)
        {
            Name = "Queen";
        }

        public override bool IsRightMove(int startCol, int startRow,
            int endCol, int endRow)
        {
            return (Math.Abs(endCol - startCol) == Math.Abs(endRow - startRow))
                   || (startCol == endCol || startRow == endRow);
        }

        public override bool IsRightMove(char startCol, int startRow,
            char endCol, int endRow)
        {
            return (Math.Abs(endCol - startCol) == Math.Abs(endRow - startRow))
                   || (startCol == endCol || startRow == endRow);
        }
    }
}