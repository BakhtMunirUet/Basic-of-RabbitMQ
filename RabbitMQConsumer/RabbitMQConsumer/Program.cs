using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;

namespace RabbitMQConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new ConnectionFactory()
            {
                //Uri = new Uri("amqp://guest:guest@localhost:8080")
                HostName = "localhost",
                UserName = "guest",
                Password = "guest",
                //Port = 15672
                
            };

            

            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();
            FanoutExchangePublisher.Consume(channel);



        }
    }
}
