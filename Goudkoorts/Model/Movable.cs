﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts
{
    public class Movable : GameObject
    {
        protected Standable _Standable;

        public bool Move()
        {
            return _Standable.MoveOntoNext(this);
        }
    }
}