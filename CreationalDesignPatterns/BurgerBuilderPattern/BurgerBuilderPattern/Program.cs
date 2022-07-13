using BurgerBuilderPattern;

var builder = new BurgerBuilder();

var director = new BurgerDirector(builder);

List<Burger> burgers = new() { };

director.Build();
burgers.Add(builder.GetBurger());

director.BuildWithoutOnion();
burgers.Add(builder.GetBurger());

director.BuildWithoutCucumber();
burgers.Add(builder.GetBurger());

foreach(var burger in burgers)
    Console.WriteLine(burger); 