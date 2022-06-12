/*
 * Chess-3
 * Kotdusov B.M. 220
 * 13.04.22
 */

using System;

namespace Chess.Core
{
    public class Queen : Piece
    {
        public Queen(char col, int row) : base(col, row)
        {
        }

        public Queen(string pos) : base(pos)
        {
        }

        public Queen(int col, int row) : base(col, row)
        {
        }

        protected override bool IsRightMove(int startCol, int startRow,
            int endCol, int endRow)
        {
            return (Math.Abs(endCol - startCol) == Math.Abs(endRow - startRow))
                   || (startCol == endCol || startRow == endRow);
        }
    }
}