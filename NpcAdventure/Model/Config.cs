﻿using StardewModdingAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NpcAdventure.Model
{
    class Config
    {
        public SButton ChangeBuffButton { get; set; } = SButton.G;
        public int HeartThreshold { get; set; } = 5;
        public bool ShowHUD { get; set; } = true;
    }
}
