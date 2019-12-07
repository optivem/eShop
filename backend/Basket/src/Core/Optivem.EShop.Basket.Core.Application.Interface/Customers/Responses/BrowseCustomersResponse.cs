﻿using System;
using System.Collections.Generic;

namespace Optivem.EShop.Basket.Core.Application.Customers.Responses
{
    public class BrowseCustomersResponse
    {
        public List<BrowseCustomersRecordResponse> Records { get; set; }

        public int TotalRecords { get; set; }
    }

    public class BrowseCustomersRecordResponse
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}