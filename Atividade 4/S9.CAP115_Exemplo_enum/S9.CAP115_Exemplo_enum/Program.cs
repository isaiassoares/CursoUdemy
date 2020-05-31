using S9.CAP115_Exemplo_enum.Entities;
using S9.CAP115_Exemplo_enum.Entities.Enums;
using System;

namespace S9.CAP115_Exemplo_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();//conversão de enumerado para string
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");//conversão de string para enum

            Console.WriteLine(txt);
            Console.WriteLine(os);

            Console.ReadKey();
        }
    }
}
