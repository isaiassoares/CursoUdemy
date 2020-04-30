using System;

namespace S7.CAP91_Demonstracao_TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);


            ///DEMO construtores
            ///
            TimeSpan t2 = new TimeSpan();
            TimeSpan t3 = new TimeSpan(900000000L);
            TimeSpan t4 = new TimeSpan(2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t6 = new TimeSpan(1, 2, 11, 21, 321);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);

            ///DEMO métodos From
            ///
            TimeSpan t7 = TimeSpan.FromDays(1.5);//um dia e meio
            TimeSpan t8 = TimeSpan.FromHours(1.5);//uma hora e meia
            TimeSpan t9 = TimeSpan.FromMinutes(1.5);//um minuto e meio
            TimeSpan t10 = TimeSpan.FromSeconds(1.5);//um segundo e meio
            TimeSpan t11 = TimeSpan.FromMilliseconds(1.5);//um milisegundo e meio
            TimeSpan t12 = TimeSpan.FromTicks(900000000L);//minto em ticks
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine(t10);
            Console.WriteLine(t11);
            Console.WriteLine(t12);
        }
    }
}
