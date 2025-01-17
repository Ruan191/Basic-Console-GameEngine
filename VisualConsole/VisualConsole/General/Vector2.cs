﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualConsole.General
{
    public class Vector2
    {
        public int x;
        public int y;
        public static readonly Vector2 zero = new Vector2();

        public Vector2()
        {
            x = 0;
            y = 0;
        }

        public static Vector2 Zero()
        {
            return new Vector2();
        }

        public Vector2(int x = 0, int y = 0)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString() => $"({x}, {y})";

        public static Vector2 operator +(Vector2 input1, Vector2 input2)
        {
            return new Vector2(input1.x + input2.x, input1.y + input2.y);
        }

        public static Vector2 operator -(Vector2 input1, Vector2 input2)
        {
            return new Vector2(input1.x - input2.x, input1.y - input2.y);
        }

        public static Vector2 operator *(Vector2 input1, Vector2 input2)
        {
            return new Vector2(input1.x * input2.x, input1.y * input2.y);
        }

        public static Vector2 operator /(Vector2 input1, Vector2 input2)
        {
            return new Vector2(input1.x / input2.x, input1.y / input2.y);
        }

        public static Vector2 operator /(Vector2 input1, int input2)
        {
            return new Vector2(input1.x / input2, input1.y / input2);
        }

        public static Vector2 operator *(Vector2 input1, int input2)
        {
            return new Vector2(input1.x * input2, input1.y * input2);
        }
    }
}
