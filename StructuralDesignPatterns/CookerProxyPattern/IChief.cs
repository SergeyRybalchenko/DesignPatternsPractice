using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookerProxyPattern
{
    public interface IChief
    {
        public IDictionary<int, string> GetStatuses();
        public IEnumerable<Order> GetOrders();
    }
}
