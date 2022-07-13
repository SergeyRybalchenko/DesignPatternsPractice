using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerBuilderPattern
{
    internal class BurgerDirector
    {
        private readonly IBurgerBuilder _builder;

        public BurgerDirector(IBurgerBuilder builder)
        {
            _builder = builder;
        }

        public void Build()
        {
            _builder
                .WithLettuce()
                .WithTomato()
                .WithCucumber()
                .WithOnion()
                .WithMeat();
        }

        public void BuildWithoutOnion()
        {
            _builder
                .WithLettuce()
                .WithTomato()
                .WithCucumber()
                .WithMeat();
        }

        public void BuildWithoutCucumber()
        {
            _builder
                .WithLettuce()
                .WithTomato()
                .WithOnion()
                .WithMeat();
        }
    }
}
