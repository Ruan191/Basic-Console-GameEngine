﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualConsole.General
{
    public class Controls
    {
        public static event EventHandler<KeyPressedHandler> OnKeyPressed;
        public static event EventHandler<CKPressedHandler> OnCKPressed;
        public class KeyPressedHandler : EventArgs
        {
            public char keyPressed;
        }

        public class CKPressedHandler : EventArgs
        {
            public ConsoleKey keyPressed;
        }

        public static char keyPressed;
        public static ConsoleKey CKPressed;
        public static async void KeyPressed()
        {
            await Task.Run(() => {
                while (true)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    CKPressed = key.Key;
                    keyPressed = key.KeyChar;

                    if (CKPressed != ConsoleKey.NoName && OnCKPressed != null)
                    {
                        OnCKPressed.Invoke(null, new CKPressedHandler() { keyPressed = CKPressed });
                    }

                    if ((int)keyPressed != 0 && OnKeyPressed != null)
                    {
                        OnKeyPressed.Invoke(null, new KeyPressedHandler() { keyPressed = keyPressed });
                    }

                    CKPressed = ConsoleKey.NoName;
                    keyPressed = ' ';

                    Task.Delay(50).Wait();
                }
            });
        }
    }
}
