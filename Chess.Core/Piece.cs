/*
 * Chess-3
 * Kotdusov B.M. 220
 * 13.04.22
 */

using System;

namespace Chess.Core
{
    public abstract class Piece<TCell>
    {
        public int Row { get; protected set; }
        public int Col { get; protected set; }
        public TCell Cell { get; set; }
        private IMoveController<TCell> _moveController;
        public string Name { get; protected set; }

        public Piece(char col, int row, TCell cell, IMoveController<TCell> controller)
        {
            Row = row;
            Col = ConvertColumnCoordToInt(char.ToUpper(col));
            Cell = cell;
            _moveController = controller;

            if (!IsValidPos(this.Col, row))
            {
                throw new Exception("Invalid position");
            }
        }

        public Piece(string pos, TCell cell, IMoveController<TCell> controller)
        {
            Row = int.Parse(pos[1].ToString());
            Col = ConvertColumnCoordToInt(char.ToUpper(pos[0]));
            Cell = cell;
            _moveController = controller;

            if (!IsValidPos(Col, Row))
            {
                throw new Exception("Invalid position");
            }
        }

        public Piece(int col, int row, TCell cell, IMoveController<TCell> controller)
        {
            Row = row;
            Col = col;
            Cell = cell;
            _moveController = controller;

            if (!IsValidPos(this.Col, this.Row))
            {
                throw new Exception("Invalid position");
            }
        }

        public abstract bool IsRightMove(int startCol, int startRow,
            int endCol, int endRow);

        public abstract bool IsRightMove(char startCol, int startRow,
            char endCol, int endRow);


        public void Move(string pos)
        {
            Move(pos[0], int.Parse(pos[1].ToString()));
        }

        public void Move(char endCol, int endRow)
        {
            int endColInt = ConvertColumnCoordToInt(endCol);

            if (IsRightMove(Col, Row, endColInt, endRow))
            {
                Row = endRow;
                Col = ConvertColumnCoordToInt(endCol);
            }
            else
            {
                Console.WriteLine("Incorrect move");
            }
        }

        public void Move(TCell destCell, char destCol, int destRow)
        {
            _moveController.Move(this, destCell, destCol, destRow);
        }

        private int ConvertColumnCoordToInt(char col)
        {
            return char.ToUpper(col) - 64;
        }

        private char ConvertColumnCoordToChar(int col)
        {
            return (char) (col + 64);
        }

        private bool IsValidPos(int col, int row)
        {
            return (row < 9 & row > 0 & col < 9 & col > 0);
        }

        public string GetPos()
        {
            return $"{ConvertColumnCoordToChar(Col)}{Row}";
        }

        public override string ToString()
        {
            return $"Type: {GetType().ToString().Split('.')[1]}\n " +
                   $"Position: {GetPos()}";
        }
    }
}