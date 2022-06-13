using Chess.Core;
using Chess.Console;

ConsoleMoveController moveController = new ConsoleMoveController();

var knight = PieceFactory<string>.ReleasePiece("Knight", "A1", "A1", moveController);
Console.WriteLine(knight);
knight.Move("A4");
Console.WriteLine(knight);
Console.WriteLine();

var queen = PieceFactory<string>.ReleasePiece("Queen", "A1", "A1", moveController);
Console.WriteLine(queen);
queen.Move("B2");
Console.WriteLine(queen);
Console.WriteLine();

var bishop = PieceFactory<string>.ReleasePiece("Bishop", "B4", "B4", moveController);
Console.WriteLine(bishop);
bishop.Move("E5");
Console.WriteLine(bishop);
Console.WriteLine();

var rook = PieceFactory<string>.ReleasePiece("Rook", "C2", "C2", moveController);
Console.WriteLine(rook);
rook.Move("C5");
Console.WriteLine(rook);
Console.WriteLine();

var king = PieceFactory<string>.ReleasePiece("King", "D4", "D4", moveController);
Console.WriteLine(king);
king.Move("E5");
Console.WriteLine(king);
Console.WriteLine();

var pawn = PieceFactory<string>.ReleasePiece("Pawn", "B2", "B2", moveController);
Console.WriteLine(pawn);
pawn.Move("B3");
Console.WriteLine(pawn);