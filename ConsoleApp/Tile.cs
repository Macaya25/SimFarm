﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Tile
    {
        
        public readonly int quality;
        public string tileName;

        public Tile(Random randNum)
        {
            quality = randNum.Next(25, 100);
            tileName = "T";
        }
    }
}
