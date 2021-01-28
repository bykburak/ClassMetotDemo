using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectOOPOdev
{
    interface IOrderService
    {
        void Add(Order order);

        void Delete(Order order);

        void Update(Order order);
    }
}
