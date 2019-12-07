﻿using Microsoft.AspNetCore.Mvc;
using Optivem.Framework.Web.AspNetCore;
using Optivem.EShop.Basket.Core.Application.Orders;
using Optivem.EShop.Basket.Core.Application.Orders.Requests;
using Optivem.EShop.Basket.Core.Application.Orders.Responses;
using System;
using System.Threading.Tasks;

namespace Optivem.EShop.Basket.Web.RestApi.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrdersController : BaseController<IOrderService>
    {
        public OrdersController(IOrderService service) : base(service)
        {
        }

        [HttpPost("{id}/archive", Name = "archive-order")]
        [ProducesResponseType(typeof(ArchiveOrderResponse), 200)]
        public async Task<ActionResult<ArchiveOrderResponse>> ArchiveOrderAsync(ArchiveOrderRequest request)
        {
            var response = await Service.ArchiveOrderAsync(request);
            return Ok(response);
        }

        [HttpGet("browse", Name = "browse-orders")]
        [ProducesResponseType(typeof(BrowseOrdersResponse), 200)]
        public async Task<ActionResult<BrowseOrdersResponse>> BrowseOrdersAsync([FromQuery] int? page = null, [FromQuery] int? size = null)
        {
            var request = new BrowseOrdersRequest
            {
                Page = page.Value,
                Size = size.Value,
            };

            var response = await Service.BrowseOrdersAsync(request);
            return Ok(response);
        }

        [HttpPost("{id}/cancel", Name = "cancel-order")]
        [ProducesResponseType(typeof(CancelOrderResponse), 200)]
        public async Task<ActionResult<CancelOrderResponse>> CancelOrderAsync(CancelOrderRequest request)
        {
            var response = await Service.CancelOrderAsync(request);
            return Ok(response);
        }

        [HttpPost(Name = "create-order")]
        [ProducesResponseType(typeof(CreateOrderResponse), 201)]
        public async Task<ActionResult<CreateOrderResponse>> CreateOrderAsync(CreateOrderRequest request)
        {
            var response = await Service.CreateOrderAsync(request);
            return CreatedAtRoute("find-order", new { id = response.Id }, response);
        }

        [HttpGet("{id}", Name = "find-order")]
        [ProducesResponseType(typeof(FindOrderResponse), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<FindOrderResponse>> FindOrderAsync(Guid id)
        {
            var request = new FindOrderRequest { Id = id };
            var response = await Service.FindOrderAsync(request);
            return Ok(response);
        }

        [HttpGet("list", Name = "list-orders")]
        [ProducesResponseType(typeof(ListOrdersResponse), 200)]
        public async Task<ActionResult<ListOrdersResponse>> ListOrdersAsync()
        {
            var request = new ListOrdersRequest();
            var response = await Service.ListOrdersAsync(request);
            return Ok(response);
        }

        [HttpPost("{id}/submit", Name = "submit-order")]
        [ProducesResponseType(typeof(SubmitOrderResponse), 200)]
        public async Task<ActionResult<SubmitOrderResponse>> SubmitOrderAsync(SubmitOrderRequest request)
        {
            var response = await Service.SubmitOrderAsync(request);
            return Ok(response);
        }

        [HttpPut("{id}", Name = "update-order")]
        [ProducesResponseType(typeof(UpdateOrderResponse), 201)]
        public async Task<ActionResult<UpdateOrderResponse>> UpdateOrderAsync(Guid id, UpdateOrderRequest request)
        {
            var response = await Service.UpdateOrderAsync(request);
            return Ok(response);
        }
    }
}
