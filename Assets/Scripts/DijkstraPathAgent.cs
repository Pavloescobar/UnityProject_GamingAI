﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    class DijkstraPathAgent:PathAgent
    {
        public override Pathfinder createPathfinder()
        {
            return new DijkstraPathFinder();
        }
    }
}
