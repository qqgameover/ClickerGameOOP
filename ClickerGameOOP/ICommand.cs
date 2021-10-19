﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerGameOOP
{
    public interface ICommand
    {
        void Run();
        char Character { get; }
    }
}
