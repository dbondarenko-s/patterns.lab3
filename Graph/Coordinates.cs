﻿namespace Patterns.Lab3.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Coordinates
    {
        public int X { get; private set; }

        public int Y { get; private set; }

        public Coordinates(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
