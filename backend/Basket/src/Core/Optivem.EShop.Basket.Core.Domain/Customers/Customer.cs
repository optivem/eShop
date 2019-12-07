﻿using Optivem.Framework.Core.Domain;

namespace Optivem.EShop.Basket.Core.Domain.Customers
{
    public class Customer : Entity<CustomerIdentity>
    {
        public Customer(CustomerIdentity id, string firstName, string lastName)
            : base(id)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}