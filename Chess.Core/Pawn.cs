/*
 * Chess-3
 * Kotdusov B.M. 220
 * 13.04.22
 */

namespace Chess.Core
{
    public class Pawn<TCell> : Piece<TCell>
    {
        public Pawn(char col, int row, TCell cell, IMoveController<TCell> controller) : base(col, row, cell, controller)
        {
            Name = "Pawn";
        }

        public Pawn(string pos, TCell cell, IMoveController<TCell> controller) : base(pos, cell, controller)
        {
            Name = "Pawn";
        }

        public Pawn(int col, int row, TCell cell, IMoveController<TCell> controller) : base(col, row, cell, controller)
        {
            Name = "Pawn";
        }

        public override bool IsRightMove(int startCol, int startRow,
            int endCol, int endRow)
        {
            if (startRow == 2)
            {
                return endRow - startRow <= 2 && startCol == endCol;
            }

            return endRow - startRow == 1 && startCol == endCol;
        }

        public override bool IsRightMove(char startCol, int startRow,
            char endCol, int endRow)
        {
            if (startRow == 2)
            {
                return endRow - startRow <= 2 && startCol == endCol;
            }

            return endRow - startRow == 1 && startCol == endCol;
        }
    }
}