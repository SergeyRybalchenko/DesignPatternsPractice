using StrategyDesignPattern.Strategies;

namespace StrategyDesignPattern
{
    internal class Waiter
    {
        private readonly string _name;
        private IDish? _dish;


        public Waiter(string name)
        {
            _name = name;
        }

        public void SetDish(IDish dish)
        {
            _dish = dish;
        }

        public void ServeDish()
        {
            if (_dish == null)
            {
                Console.WriteLine("У официанта нет блюда");
                return;
            }

            Console.WriteLine($"{_name} подаёт блюдо");
            _dish.Serve();
        }
    }
}
