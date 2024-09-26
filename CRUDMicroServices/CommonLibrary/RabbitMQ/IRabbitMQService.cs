using RabbitMQ.Client;

namespace CommonLibrary.RabbitMQ
{
    public interface IRabbitMQService
    {
        IConnection CreateChannel();
    }
}
