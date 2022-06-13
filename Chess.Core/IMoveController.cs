﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Core
{
    public interface IMoveController<TCell>
    {
        public void Move(Piece<TCell> piece, TCell destCell, char destCol, int destRow);
    }
}