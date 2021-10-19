﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerGameOOP
{
    class ExitCommand : ICommand
    {
        public char Character { get; } = 'X';
        public void Run()
        {
            Environment.Exit(0);
        }
    }
}
