using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerBuilderPattern
{
    public interface IBurgerBuilder
    {
        IBurgerBuilder WithTomato();
        IBurgerBuilder WithMeat();
        IBurgerBuilder WithLettuce();
        IBurgerBuilder WithCucumber();
        IBurgerBuilder WithOnion();

        Burger GetBurger(); 
    }
}
