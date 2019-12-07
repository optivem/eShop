﻿using System.Threading.Tasks;

namespace Optivem.EShop.Basket.Core.Domain.Customers
{
    public interface ICustomerRepository : ICustomerReadRepository
    {
        void Add(Customer customer);

        Task UpdateAsync(Customer customer);

        void Remove(CustomerIdentity customerId);
    }
}