using System;
using System.Collections.Generic;
using ALLINONE.DATA;

namespace ALLINONE.SERVICE
{
    public interface IOrderRepository
    {
        Order GetById(Int32 id);
        void Insert(Order model);
        void Update(Order model);
        void Delete(Order model);
        IEnumerable<Order> GetOrders();
    }
}
