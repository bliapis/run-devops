using Chopping.API.Models.Commands.Order;
using Chopping.API.Models.DTO.Order;
using Silverback.Messaging.Publishing;
using System.Threading.Tasks;

namespace Chopping.API.Publishers
{
    public class OrderPublisher
    {
        private readonly IPublisher _publisher;

        public OrderPublisher(IPublisher publisher)
        {
            _publisher = publisher;
        }

        public async Task Publish(CreateOrder createOrder)
        {
            var command = new CreateOrderCommand(createOrder);

            await _publisher.PublishAsync(command);
        }
    }
}