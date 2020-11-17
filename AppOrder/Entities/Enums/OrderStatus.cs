using System;
using System.Collections.Generic;
using System.Text;

namespace AppOrder.Entities.Enums
{
    public enum OrderStatus : int
    {
        Delivered = 0,
        PendingPayment = 1,
        Processing = 2,
        Shipped = 3
    }
}
