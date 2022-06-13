using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Core
{
    public static class PieceFactory<TCell>
    {
        static public Piece<TCell> ReleasePiece(string? pieceName, string pos, TCell cell, IMoveController<TCell> controller)
        {
            return pieceName switch
            {
                "Pawn" => new Pawn<TCell>(pos, cell, controller),
                "Bishop" => new Bishop<TCell>(pos, cell, controller),
                "King" => new King<TCell>(pos, cell, controller),
                "Knight" => new Knight<TCell>(pos, cell, controller),
                "Queen" => new Queen<TCell>(pos, cell, controller),
                "Rook" => new Rook<TCell>(pos, cell, controller),
                _ => new Pawn<TCell>(pos, cell, controller),
            };
        }
    }
}
