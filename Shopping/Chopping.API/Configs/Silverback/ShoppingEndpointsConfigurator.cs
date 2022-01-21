using Chopping.API.Models.Commands.Order;
using Silverback.Messaging.Configuration;

namespace Chopping.API.Configs.Silverback
{
    public class ShoppingEndpointsConfigurator : IEndpointsConfigurator
    {
        public void Configure(IEndpointsConfigurationBuilder builder) =>
            builder
                .AddKafkaEndpoints(endpoints => endpoints
                    .Configure(config =>
                    {
                        config.BootstrapServers = "PLAINTEXT://localhost:9092";
                    })
                    .AddInbound(endpoint => endpoint
                        .ConsumeFrom("basket-events")
                        .Configure(config =>
                        {
                            config.GroupId = "shopping-service";
                        }))
                    .AddInbound(endpoint => endpoint
                        .ConsumeFrom("payment-events")
                        .Configure(config =>
                        {
                            config.GroupId = "shopping-service";
    
                        }))
                    .AddOutbound<CreateOrderCommand>(
                        endpoint => endpoint
                            .ProduceTo("shopping-create-order")));
    }
}