using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookerProxyPattern
{
    public class Chief : IChief
    {
        public IDictionary<int, string> GetStatuses()
        {
            Dictionary<int, string> statuses = new();

            statuses.Add(1, "ready");
            statuses.Add(2, "not ready");
            statuses.Add(3, "preparing");

            Thread.Sleep(2000);

            return statuses;
        }

        public IEnumerable<Order> GetOrders()
        {
            List<Order> orders = new();

            orders.Add(new Order() { Name = "Burger", Status = new Random().Next(1,4) });
            orders.Add(new Order() { Name = "Pasta", Status = new Random().Next(1, 4) });
            orders.Add(new Order() { Name = "Pizza", Status = new Random().Next(1, 4) });

            return orders;
        }
    }
}
