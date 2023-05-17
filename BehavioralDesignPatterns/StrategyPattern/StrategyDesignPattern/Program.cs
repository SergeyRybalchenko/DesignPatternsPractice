using StrategyDesignPattern;
using StrategyDesignPattern.Strategies;

var waiter = new Waiter("Антон");

waiter.ServeDish();

waiter.SetDish(new Pizza());
waiter.ServeDish();

waiter.SetDish(new Burger());
waiter.ServeDish();

waiter.SetDish(new Pasta());
waiter.ServeDish();