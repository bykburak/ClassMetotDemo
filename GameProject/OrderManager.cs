using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectOOPOdev
{
    class OrderManager : IOrderService
    {
        public void Add(Order order)
        {
            Console.WriteLine("Kampanya başarılı bir şekilde eklendi: " + order.OrderPrice);
        }

        public void Delete(Order order)
        {
            Console.WriteLine("Kampanya başarılı bir şekilde silindi: " + order.OrderPrice);
        }

        public void Update(Order order)
        {
            Console.WriteLine("Kampanya başarılı bir şekilde Güncellendi: " + order.OrderPrice);
        }
    }
}
