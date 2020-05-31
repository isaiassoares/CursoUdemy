using System;
using S9.CAP115_Exemplo_enum.Entities.Enums;


namespace S9.CAP115_Exemplo_enum.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }

    }
}
