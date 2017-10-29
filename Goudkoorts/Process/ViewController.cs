﻿using Goudkoorts.Model;
using Goudkoorts.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goudkoorts.Process
{
    public class ViewController
    {
        private CLI _CLI;
        public bool IsSendingModelString;
        public ViewController(GameController controller)
        {
            _CLI = new CLI();
            IsSendingModelString = false;
        }

        /*
        public void PrintCLI(Tile firstTile)
        {
            Tile currentxaxistile = firstTile;
            Tile currentyaxistile = firstTile;
            while (currentyaxistile != null)
            {
                if (currentxaxistile is Switch)
                {
                    _CLI.SetColorForSwitch();
                    _CLI.PrintChar(currentxaxistile.ToChar());
                    _CLI.ResetColor();
                }
                else
                {
                    _CLI.PrintChar(currentxaxistile.ToChar());
                }

                if (currentxaxistile._East != null)
                    currentxaxistile = currentxaxistile._East;
                else
                {
                    currentyaxistile = currentyaxistile._South;
                    currentxaxistile = currentyaxistile;
                    _CLI.WriteEnter();
                }
            }
        } */

        public int GetInput()
        {
            return _CLI.GetInput();
        }

        public void DisplayGameOver(int points)
        {
            _CLI.DisplayMessage("Game Over\n You ended with " + points + " points!");
        }
        
        public void SendModelStringToView(Tile firstTile)
        {
            if (!IsSendingModelString)
            {
                IsSendingModelString = true;
                _CLI.ReceiveModelString(GenerateModelString(firstTile));
                IsSendingModelString = false;
            }
        }

        public String GenerateModelString(Tile firstTile)
        {
            String ModelString = "";
            Tile currentxaxistile = firstTile;
            Tile currentyaxistile = firstTile;
            while (currentyaxistile != null)
            {
                ModelString += currentxaxistile.ToString();

                if (currentxaxistile._East != null)
                    currentxaxistile = currentxaxistile._East;
                else
                {
                    ModelString += "\n";
                    currentyaxistile = currentyaxistile._South;
                    currentxaxistile = currentyaxistile;
                }
            }
            return ModelString;
        }
    }
}
