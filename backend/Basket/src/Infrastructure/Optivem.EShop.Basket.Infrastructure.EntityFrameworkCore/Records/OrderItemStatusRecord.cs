using Optivem.Framework.Infrastructure.EntityFrameworkCore;
using Optivem.EShop.Basket.Core.Common.Orders;
using System.Collections.Generic;

namespace Optivem.EShop.Basket.Infrastructure.EntityFrameworkCore.Records
{
    public class OrderItemStatusRecord : Record<OrderItemStatus>
    {
        public OrderItemStatusRecord()
        {
            OrderItems = new HashSet<OrderItemRecord>();
        }

        public string Code { get; set; }

        public virtual ICollection<OrderItemRecord> OrderItems { get; set; }
    }
}