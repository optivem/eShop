using System.Threading.Tasks;

namespace Optivem.EShop.Basket.Core.Domain.Orders
{
    public interface IOrderRepository : IOrderReadRepository
    {
        void Add(Order order);

        Task UpdateAsync(Order order);

        void Remove(OrderIdentity orderId);
    }
}