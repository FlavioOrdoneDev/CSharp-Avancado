using AppRentACar.Entities;
using AppRentACar.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppRentACar.Services
{
    public class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private readonly ITaxService _taxServices;


        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxServices)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxServices = taxServices;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment;

            if (duration.TotalHours <= 12)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxServices.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
