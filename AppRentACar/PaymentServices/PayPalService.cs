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
            int count = 1;
            
            while (count <= contract.Installments)
            {
                double parcela = contract.Total / contract.Installments;
                parcela += parcela * 0.01 * count;
                contract.ValueInstallments.Add(new Installments(parcela + (parcela * 0.02), contract.Date.AddMonths(count)));
                count++;
            }
        }        
    }
}
