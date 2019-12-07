﻿using Microsoft.EntityFrameworkCore;
using Optivem.Framework.Core.Domain;
using Optivem.EShop.Basket.Core.Domain.Customers;
using Optivem.EShop.Basket.Infrastructure.EntityFrameworkCore.Records;
using System.Threading.Tasks;

namespace Optivem.EShop.Basket.Infrastructure.EntityFrameworkCore.Repositories
{
    public class CustomerRepository : CustomerReadRepository, ICustomerRepository
    {
        public CustomerRepository(DatabaseContext context) : base(context)
        {
        }

        public void Add(Customer customer)
        {
            var customerRecord = GetCustomerRecord(customer);
            Context.Customers.Add(customerRecord);
        }

        public void Remove(CustomerIdentity customerId)
        {
            var customerRecord = GetCustomerRecord(customerId);
            Context.Remove(customerRecord);
        }

        public async Task UpdateAsync(Customer customer)
        {
            var customerRecordId = customer.Id.Id;
            var customerRecord = await Context.Customers.FindAsync(customerRecordId);

            UpdateCustomerRecord(customerRecord, customer);

            try
            {
                Context.Customers.Update(customerRecord);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new ConcurrentUpdateException(ex.Message, ex);
            }
        }

        private CustomerRecord GetCustomerRecord(Customer customer)
        {
            var id = customer.Id.Id;
            var firstName = customer.FirstName;
            var lastName = customer.LastName;

            return new CustomerRecord
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
            };
        }

        private CustomerRecord GetCustomerRecord(CustomerIdentity customerId)
        {
            var id = customerId.Id;

            return new CustomerRecord
            {
                Id = id,
            };
        }

        private void UpdateCustomerRecord(CustomerRecord customerRecord, Customer customer)
        {
            var id = customer.Id.Id;
            var firstName = customer.FirstName;
            var lastName = customer.LastName;

            customerRecord.Id = id;
            customerRecord.FirstName = firstName;
            customerRecord.LastName = lastName;
        }
    }
}