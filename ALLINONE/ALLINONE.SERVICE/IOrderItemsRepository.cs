using System;
using System.Collections.Generic;
using ALLINONE.DATA;

namespace ALLINONE.SERVICE
{
public  interface IOrderItemsRepository
    {
        OrderItem GetById(Int32 id);
        void Insert(OrderItem model);
        void Update(OrderItem model);
        void Delete(OrderItem model);
        IEnumerable<OrderItem> GetOrderItems();
    }
}
