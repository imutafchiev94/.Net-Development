﻿using ViceCity.Core;
using ViceCity.Core.Contracts;
using System;
using ViceCity.Models.Players;

namespace ViceCity
{
    public class StartUp
    {
        IEngine engine;
        static void Main(string[] args)
        {
            MainPlayer mainPlayer = new MainPlayer();

            IEngine engine = new Engine();
            engine.Run();
        }
    }
}