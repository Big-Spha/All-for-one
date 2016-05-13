using System;
using System.Collections.Generic;
using ALLINONE.DATA;

namespace ALLINONE.SERVICE
{
  public  interface IItemRepository
    {
        Item GetById(Int32 id);
        void Insert(Item model);
        void Update(Item model);
        void Delete(Item model);
        IEnumerable<Item> GetItems();
    }
}
