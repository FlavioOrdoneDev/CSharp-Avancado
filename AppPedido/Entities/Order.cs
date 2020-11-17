using AppPedido.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppPedido.Entities
{
    public class Order
    {        
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public override string ToString()
        {
            return "Id " + Id + ", Moment " + Moment + ", Status " + OrderStatus;
        }
    }
}
