using StayCation.Hotel.Core.DTO;

namespace StayCation.Hotel.Core.Interfaces
{
    public interface IPaymentService
    {
        Task<List<PaymentDto>> GetAllPayments();
        Task<PaymentDto> GetPaymentById(string id);
        Task MakePayment(PaymentDto paymentDto);
    }
}