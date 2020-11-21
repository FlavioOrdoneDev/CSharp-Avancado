using AppRentACar.Entities;
using AppRentACar.Services;
using System;

namespace AppRentACar
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle veiculo = new Vehicle("Civic");

            CarRental carRental1 = new CarRental(DateTime.Parse("25/06/2018 10:30"), DateTime.Parse("25/06/2018 14:40"), veiculo);
            CarRental carRental2 = new CarRental(DateTime.Parse("25/06/2018 10:30"), DateTime.Parse("27/06/2018 11:40"), veiculo);            

            RentalService rentalService = new RentalService(10, 130);

            rentalService.ProcessInvoice(carRental1);
            rentalService.ProcessInvoice(carRental2);

            Console.WriteLine("Invoice 1:");
            Console.WriteLine(carRental1.Invoice);

            Console.WriteLine();

            Console.WriteLine("Invoice 2:");
            Console.WriteLine(carRental2.Invoice);

            Console.ReadKey();
        }
    }
}
