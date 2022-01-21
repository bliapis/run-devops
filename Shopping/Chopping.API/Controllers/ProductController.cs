using Chopping.API.Models.DTO.Order;
using Chopping.API.Publishers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using Shopping.API.Data;
using Shopping.API.Models;
using Silverback.Messaging.Publishing;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chopping.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ProductContext _context;
        private readonly OrderPublisher _orderPublisher;
        private readonly ILogger<ProductController> _logger;

        public ProductController(
            ProductContext productContext, 
            IPublisher publisher,
            ILogger<ProductController> logger)
        {
            _context = productContext;
            _orderPublisher = new OrderPublisher(publisher);
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            return await _context
                            .Products
                            .Find(p => true)
                            .ToListAsync();
        }

        [HttpPost("CreateOrderCommand")]
        public async Task SendCreateOrderCommand(CreateOrder createOrder)
        {
            try
            {
                await _orderPublisher.Publish(createOrder);
            }
            catch(Exception ex)
            {
                var t = ex;

                var rr = t.Message;
            }

            return;
        }
    }
}