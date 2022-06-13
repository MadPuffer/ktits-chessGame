/*
 * Chess-3
 * Kotdusov B.M. 220
 * 13.04.22
 */

using System;

namespace Chess.Core
{
    public class King<TCell> : Piece<TCell>
    {
        public King(char col, int row, TCell cell, IMoveController<TCell> controller) : base(col, row, cell, controller)
        {
            Name = "King";
        }

        public King(string pos, TCell cell, IMoveController<TCell> controller) : base(pos, cell, controller)
        {
            Name = "King";
        }

        public King(int col, int row, TCell cell, IMoveController<TCell> controller) : base(col, row, cell, controller)
        {
            Name = "King";
        }

        public override bool IsRightMove(int startCol, int startRow,
            int endCol, int endRow)
        {
            return Math.Abs(startCol - endCol) < 2 &&
                   Math.Abs(startRow - endRow) < 2;
        }

        public override bool IsRightMove(char startCol, int startRow,
            char endCol, int endRow)
        {
            return Math.Abs(startCol - endCol) < 2 &&
                   Math.Abs(startRow - endRow) < 2;
        }
    }
}