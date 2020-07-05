using System;
using System.Globalization;
using S14.CAP195_196_Solucao_sem_interface.Entities;
using S14.CAP195_196_Solucao_sem_interface.Services;

namespace S14.CAP195_196_Solucao_sem_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy HH:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy HH:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(hour, day);

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE:");
            Console.WriteLine(carRental.Invoice);


            Console.ReadKey();
        }
    }
}
