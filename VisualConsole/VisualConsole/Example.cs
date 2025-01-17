﻿using System;
using VisualConsole.General;
using VisualConsole.Animations;
using System.Threading.Tasks;

namespace VisualConsole
{
    class Example : Play
    {
        //Example code on how to use the framework

        public override void SubHere()
        {
            Start += _Start;
            Update += _Update;
            Controls.OnKeyPressed += _OnKeyPressed;
            Controls.OnCKPressed += _OnCKPressed;
        }

        Sprite sprite;
        int animationSpeed = 1;
        Random random = new Random();
        Animation animation;
        int frameCount = 0;

        public override void _Start(object sender, EventArgs e)
        {
            sprite = new Sprite("BA75.txt", new Vector2());

            animation = new Animation("dance", new Vector2(), color:ConsoleColor.Red);
            animation.pausesBetweenFrames = animationSpeed;

            animation.Play(() =>
            {
                if (++frameCount % 50 == 0)
                {
                    animation.color = (ConsoleColor)random.Next(1, 15);
                }
            });
            
            if (OperatingSystem.IsWindows())
            {
                Console.SetWindowSize(sprite.size.x, sprite.size.y + 5);
                Console.SetWindowPosition(0, 0);
            }

            MapObject welcomeText = new MapObject("Thank you for trying out VisualConsole!");
            welcomeText.position = new Vector2((sprite.size.x / 2) - (welcomeText.ToString().Length / 2) - 3, sprite.size.y + 2);//new Vector2((sprite.size.x / 2) - (welcomeText.ToString().Length / 2), sprite.size.y + 3);
            welcomeText.Render();
        }

        public override void _Update(object sender, EventArgs e)
        {
            
        }

        void _OnKeyPressed(object sender, Controls.KeyPressedHandler e)
        {
            
        }

        void _OnCKPressed(object sender, Controls.CKPressedHandler e)
        {

        }

        public override void Remove()
        {
            Controls.OnKeyPressed -= _OnKeyPressed;
            Controls.OnCKPressed -= _OnCKPressed;
        }
    }
}
