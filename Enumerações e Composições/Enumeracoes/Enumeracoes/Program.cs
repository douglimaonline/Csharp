using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;

namespace Enumeracoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Order order = new Order();
            order.Id = 1080;
            order.Moment = DateTime.Now;
            order.Status = OrderStatus.Processing;

            Console.WriteLine(order);

            // Convertendo string para o Enum

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
        }
    }
}