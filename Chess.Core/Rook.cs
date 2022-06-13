/*
 * Chess-3
 * Kotdusov B.M. 220
 * 13.04.22
 */

namespace Chess.Core
{
    public class Rook : Piece
    {
        public Rook(char col, int row) : base(col, row)
        {
        }

        public Rook(string pos) : base(pos)
        {
        }

        public Rook(int col, int row) : base(col, row)
        {
        }

        public override bool IsRightMove(int startCol, int startRow,
            int endCol, int endRow)
        {
            return startCol == endCol || startRow == endRow;
        }

        public override bool IsRightMove(char startCol, int startRow,
            char endCol, int endRow)
        {
            return startCol == endCol || startRow == endRow;
        }
    }
}