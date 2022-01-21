using System;

namespace Chopping.API.Models.DTO.Order
{
    public class CreateOrder
    {
        private Guid OrderId { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid CustomerId { get; set; }
        public int ProductNumber { get; set; }

        public Guid GetOrderId()
        {
            return OrderId;
        }

        public CreateOrder()
        {
            OrderId = Guid.NewGuid();
        }
    }
}