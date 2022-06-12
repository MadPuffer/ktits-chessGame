/*
 * Chess-3
 * Kotdusov B.M. 220
 * 13.04.22
 */

using System;

namespace Chess.Core
{
    public abstract class Piece
    {
        private int _row;
        private int _col;

        public Piece(char col, int row)
        {
            this._row = row;
            this._col = ConvertColumnCoordToInt(char.ToUpper(col));

            if (!IsValidPos(this._col, row))
            {
                throw new Exception("Invalid position");
            }
        }

        public Piece(string pos)
        {
            _row = int.Parse(pos[1].ToString());
            _col = ConvertColumnCoordToInt(char.ToUpper(pos[0]));

            if (!IsValidPos(_col, _row))
            {
                throw new Exception("Invalid position");
            }
        }

        public Piece(int col, int row)
        {
            this._row = row;
            this._col = col;

            if (!IsValidPos(this._col, this._row))
            {
                throw new Exception("Invalid position");
            }
        }

        protected abstract bool IsRightMove(int startCol, int startRow,
            int endCol, int endRow);


        public void Move(string pos)
        {
            this.Move(pos[0], int.Parse(pos[1].ToString()));
        }

        public void Move(char endCol, int endRow)
        {
            int endColInt = ConvertColumnCoordToInt(endCol);

            if (IsRightMove(_col, _row, endColInt, endRow))
            {
                _row = endRow;
                _col = ConvertColumnCoordToInt(endCol);
            }
            else
            {
                Console.WriteLine("Incorrect move");
            }
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
            return $"{ConvertColumnCoordToChar(_col)}{_row}";
        }

        public override string ToString()
        {
            return $"Type: {GetType().ToString().Split('.')[1]}\n " +
                   $"Position: {GetPos()}";
        }
    }
}