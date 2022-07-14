using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.Strategies
{
    internal class Pasta : IDish
    {
        public void Serve()
        {
            Console.WriteLine("Паста подана");
        }
    }
}
