﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goudkoorts
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            GameController gc = new GameController();
            gc.StartGame();
        }
    }
}
