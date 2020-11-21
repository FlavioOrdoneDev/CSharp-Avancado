using AppRentACar.Entities;
using AppRentACar.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppRentACar.PaymentServices
{
    public class PayPalService : IPaymentService
    {
        public void Calculate(Contract contract)
        {
            int installments = contract.Installments;
            int count = 0;
            
            while (count < contract.Installments)
            {
                double parcela = contract.Total / contract.Installments;
                parcela += parcela * 0.01 * installments;
                contract.ValueInstallments.Add(parcela + (parcela * 0.02));
                count++;
                installments--;
            }
        }
    }
}
