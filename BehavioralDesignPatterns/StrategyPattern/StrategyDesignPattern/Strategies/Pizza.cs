﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.Strategies
{
    internal class Pizza : IDish
    {
        public void Serve()
        {
            Console.WriteLine("Пицца подана");
        }
    }
}
