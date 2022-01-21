using Chopping.API.Models.DTO.Order;
using Silverback.Messaging.Messages;
using System;

namespace Chopping.API.Models.Commands.Order
{
    public class CreateOrderCommand : Command<CreateOrder>
    {
        [KafkaKeyMember]
        public Guid? Key { get; set; }

        public CreateOrderCommand(CreateOrder createOrder) : base(createOrder)
        {
            Key = createOrder?.GetOrderId();
        }
    }
}