/*
 * Chess-3
 * Kotdusov B.M. 220
 * 13.04.22
 */

using System;

namespace Chess.Core
{
    public class Knight : Piece
    {
        public Knight(char col, int row) : base(col, row)
        {
        }

        public Knight(string pos) : base(pos)
        {
        }

        public Knight(int col, int row) : base(col, row)
        {
        }

        protected override bool IsRightMove(int startCol, int startRow,
            int endCol, int endRow)
        {
            return Math.Pow(startCol - endCol, 2) +
                   Math.Pow(startRow - endRow, 2) == 5;
        }
    }
}