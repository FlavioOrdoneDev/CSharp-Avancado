using AppRentACar.Entities;

namespace AppRentACar.Interfaces
{
    public interface IPaymentService
    {
        void Calculate(Contract contract);
    }
}
