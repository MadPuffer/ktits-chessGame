/*
 * Chess-3
 * Kotdusov B.M. 220
 * 13.04.22
 */

using System;

namespace Chess.Core
{
    public class King : Piece
    {
        public King(char col, int row) : base(col, row)
        {
        }

        public King(string pos) : base(pos)
        {
        }

        public King(int col, int row) : base(col, row)
        {
        }

        protected override bool IsRightMove(int startCol, int startRow,
            int endCol, int endRow)
        {
            return Math.Abs(startCol - endCol) < 2 &&
                   Math.Abs(startRow - endRow) < 2;
        }
    }
}