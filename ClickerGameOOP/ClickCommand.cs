﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerGameOOP
{
    class ClickCommand : ICommand
    {
        private ClickerGame _game;
        public char Character { get; } = ' ';

        public ClickCommand(ClickerGame game)
        {
            _game = game;
        }
        public void Run()
        {
            _game.Click();
        }

    }
}
