using System;
using System.Collections.Generic;

namespace Optivem.EShop.Basket.Core.Application.Orders.Responses
{
    public class BrowseOrdersResponse
    {
        public List<BrowseOrdersRecordResponse> Records { get; set; }

        public int TotalRecords { get; set; }
    }

    public class BrowseOrdersRecordResponse
    {
        public Guid Id { get; set; }
    }
}