using CookerProxyPattern;

IChief chief = new ChiefProxy(new Chief());

while (true)
{
    Thread.Sleep(2000);

    Console.Clear();

    Console.WriteLine("Welcome to Cooker!");
    Console.WriteLine("Order:");

    var orders = chief.GetOrders();

    foreach(var order in orders)
    {
        string status = chief.GetStatuses().First(s => s.Key == order.Status).Value;

        Console.WriteLine($"{order.Name}\t\t{status}"); 
    }   
}