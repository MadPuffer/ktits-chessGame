using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Chess.Core;

namespace Chess.WPF
{
    internal class WPFMoveController : IMoveController<Button>
    {
        public void Move(Piece<Button> piece, Button destCell, char destCol, int destRow)
        {
            piece.Move(destCol, destRow);
            piece.Cell.Content = null;
            destCell.Content = piece.Name;
            piece.Cell = destCell;
        }

        public void ValidateCell(Piece<Button> piece, Button destCell)
        {
            string? pos = destCell.Tag.ToString();
            if (piece.IsRightMove(piece.Col, piece.Row, pos[0], int.Parse(pos[1].ToString())) || destCell.Content == null)
                destCell.Content = "Valid cell";
            else
                destCell.Content = "Invalid cell";
        }

        public void ClearCell(Button cell)
        {
            if (cell.Content?.ToString() == "Valid cell" || cell.Content?.ToString() == "Invalid cell")
                cell.Content = null;
        }
    }
}
