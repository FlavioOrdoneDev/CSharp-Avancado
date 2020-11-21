using AppRentACar.Entities;
using AppRentACar.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppRentACar.PaymentServices
{
    public class ContractService
    {
        private readonly IPaymentService _paymentService;

        public ContractService(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void CalculatePayment(Contract contract)
        {
            _paymentService.Calculate(contract);
        }
    }
}
