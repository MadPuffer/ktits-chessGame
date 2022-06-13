/*
 * Chess-3
 * Kotdusov B.M. 220
 * 13.04.22
 */

namespace Chess.Core
{
    public class Rook<TCell> : Piece<TCell>
    {
        public Rook(char col, int row, TCell cell, IMoveController<TCell> controller) : base(col, row, cell, controller)
        {
            Name = "Rook";
        }

        public Rook(string pos, TCell cell, IMoveController<TCell> controller) : base(pos, cell, controller)
        {
            Name = "Rook";
        }

        public Rook(int col, int row, TCell cell, IMoveController<TCell> controller) : base(col, row, cell, controller)
        {
            Name = "Rook";
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