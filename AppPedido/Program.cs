using AppPedido.Entities;
using AppPedido.Enums;
using System;

namespace AppPedido
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

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus status = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(status);

            Console.ReadKey();
        }
    }
}
