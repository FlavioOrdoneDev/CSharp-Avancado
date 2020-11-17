using AppOrder.Entities;
using AppOrder.Entities.Enums;
using System;

namespace AppOrder
{
    class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                OrderStatus = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            Console.ReadKey();
        }
    }
}
