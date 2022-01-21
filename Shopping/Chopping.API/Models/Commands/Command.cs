using Silverback.Messaging.Messages;

namespace Chopping.API.Models.Commands
{
    public abstract class Command<T> : IIntegrationCommand
    {
        protected Command(T payload)
        {
            Payload = payload;
        }

        public System.Guid Id { get; set; }

        public T Payload { get; set; }
    }

    public abstract class Command<T, TResult> : ICommand<TResult>
    {
        protected Command(T payload)
        {
            Payload = payload;
        }

        public System.Guid Id { get; set; }

        public T Payload { get; set; }
    }
}