using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookerProxyPattern
{
    internal class ChiefProxy : IChief
    {
        private readonly Chief _chief;

        private IDictionary<int, string>? _statuses;

        public ChiefProxy(Chief chief)
        {
            _chief = chief;
        }

        public IEnumerable<Order> GetOrders()
        {
            return _chief.GetOrders();
        }

        public IDictionary<int, string> GetStatuses()
        {
            if (_statuses == null)
            {
                _statuses = _chief.GetStatuses();
            }

            return _statuses;
        }
    }
}
