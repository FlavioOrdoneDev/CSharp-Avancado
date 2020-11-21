using AppRentACar.Entities;
using AppRentACar.Interfaces;
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

            RentalService rentalServiceBrazil = new RentalService(10, 130, new BrazilTaxServices());
            RentalService rentalServiceEuropa = new RentalService(20, 260, new EuropeTaxServices());

            rentalServiceBrazil.ProcessInvoice(carRental1);
            rentalServiceBrazil.ProcessInvoice(carRental2);            

            Console.WriteLine("Invoice 1 Brasil:");
            Console.WriteLine(carRental1.Invoice);

            Console.WriteLine();

            Console.WriteLine("Invoice 2 Brasil:");
            Console.WriteLine(carRental2.Invoice);

            Console.WriteLine();

            rentalServiceEuropa.ProcessInvoice(carRental1);
            rentalServiceEuropa.ProcessInvoice(carRental2);

            Console.WriteLine("Invoice 1 Europa:");
            Console.WriteLine(carRental1.Invoice);

            Console.WriteLine();

            Console.WriteLine("Invoice 2 Europa:");
            Console.WriteLine(carRental2.Invoice);

            Console.ReadKey();
        }
    }
}
