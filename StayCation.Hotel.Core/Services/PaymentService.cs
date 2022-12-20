using AutoMapper;
using StayCation.Hotel.Core.DTO;
using StayCation.Hotel.Core.Interfaces;
using StayCation.Hotel.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayCation.Hotel.Core.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper _mapper;
        public PaymentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<PaymentDto> GetPaymentById(string id)
        {
            var payment = await unitOfWork.PaymentRepository.GetAsync(x => x.Id == id);
            return _mapper.Map<PaymentDto>(payment);
        }
        public async Task<List<PaymentDto>> GetAllPayments()
        {
            var payments = await unitOfWork.PaymentRepository.GetAllAsync();
            return _mapper.Map<List<PaymentDto>>(payments);
        }
        public async Task MakePayment(PaymentDto paymentDto)
        {
            var payment = _mapper.Map<Payment>(paymentDto);
            await unitOfWork.Save();
        }
    }
}
