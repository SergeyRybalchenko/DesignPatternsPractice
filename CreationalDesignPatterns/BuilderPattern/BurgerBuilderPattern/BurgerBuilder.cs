using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerBuilderPattern
{
    internal class BurgerBuilder : IBurgerBuilder
    {
        private Burger _burger;

        public BurgerBuilder()
        {
            _burger = new();
        }

        public IBurgerBuilder WithTomato()
        {
            _burger.Tomato = true;
            return this;
        }

        public IBurgerBuilder WithMeat()
        {
            _burger.Meat = true;
            return this;
        }

        public IBurgerBuilder WithLettuce()
        {
            _burger.Lettuce = true;
            return this;
        }

        public IBurgerBuilder WithCucumber()
        {
            _burger.Cucumber = true;
            return this;
        }

        public IBurgerBuilder WithOnion()
        {
            _burger.Onion = true;
            return this;
        }

        public Burger GetBurger()
        {
            Burger burger = _burger;

            _burger = new();

            return burger;
        }
    }
}
