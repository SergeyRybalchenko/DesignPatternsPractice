using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerBuilderPattern
{
    public class Burger
    {
        public bool Tomato { get; set; }
        public bool Meat { get; set; }
        public bool Lettuce { get; set; }
        public bool Cucumber { get; set; }
        public bool Onion { get; set; }

        public override string ToString()
        {
            string BurgerString = "Burger";
            BurgerString += Tomato == true ? " with tomato" : "";
            BurgerString += Meat == true ? " with meat" : "";
            BurgerString += Lettuce == true ? " with lettuce" : "";
            BurgerString += Cucumber == true ? " with cucumber" : "";
            BurgerString += Onion == true ? " with onion" : "";
            return BurgerString;
        }
    }
}
