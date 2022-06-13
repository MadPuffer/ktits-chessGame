using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Core
{
    public static class PieceFactory
    {
        static public Piece ReleasePiece(string? pieceName, string pos)
        {
            return pieceName switch
            {
                "Pawn" => new Pawn(pos),
                "Bishop" => new Bishop(pos),
                "King" => new King(pos),
                "Knight" => new Knight(pos),
                "Queen" => new Queen(pos),
                "Rook" => new Rook(pos),
                _ => new Pawn(pos),
            };
        }
    }
}
