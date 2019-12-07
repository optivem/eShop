using Optivem.Framework.Core.Domain;
using Optivem.EShop.Basket.Core.Common.Orders;
using Optivem.EShop.Basket.Core.Domain.Products;

namespace Optivem.EShop.Basket.Core.Domain.Orders
{
    public class OrderItem : Entity<OrderItemIdentity>
    {
        public OrderItem(OrderItemIdentity id, ProductIdentity productId, decimal quantity, decimal unitPrice, OrderItemStatus status)
            : base(id)
        {
            ProductId = productId;
            Quantity = quantity;
            UnitPrice = unitPrice;
            Status = status;
        }

        public ProductIdentity ProductId { get; private set; }

        public decimal UnitPrice { get; private set; }

        public void SetProduct(Product product)
        {
            ProductId = product.Id;
            UnitPrice = product.ListPrice;
        }

        public decimal Quantity { get; set; }

        public OrderItemStatus Status { get; }
    }
}