﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts.Presentation
{
    public class CLI : IView
    {
        private void RefreshCLI(String modelString)
        {
            Console.Clear();
            foreach (var x in modelString)
            {
                if (x == 'S')
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                else if (x == '\n') // For a new line, idk what the new line is in the modelString
                {
                    Console.WriteLine();
                }
                else if (x == '+')
                {
                    Console.Write("Your score is: ");
                }
                else
                {
                    Console.Write(x);
                    Console.ResetColor();
                }

            }
        }

        public int GetInput()
        {
            int input;
            do
            {
                int.TryParse(Console.ReadKey().KeyChar.ToString(), out input);
            } while (!(input > 0 && input < 10));
            return input - 1;
            /* if (int.TryParse(key.ToString(), out switchInt))
            {
                if (switchInt > 0 && switchInt < controller._Game._Level.SwitchList.Count)
                {
                    controller.SwitchTheSwitch(switchInt);
                    return true;
                }
            }
            return false;
            */
        }


        public void DisplayMessage(String message)
        {
            Console.Clear();
            Console.WriteLine(message);
            Console.ReadLine();
        }

        public void ReceiveModelString(string modelString)
        {
            RefreshCLI(modelString);
        }
    }
}