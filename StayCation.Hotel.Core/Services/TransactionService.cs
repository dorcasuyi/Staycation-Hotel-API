using AutoMapper;
using StayCation.Hotel.Core.DTO;
using StayCation.Hotel.Core.Interfaces;
using StayCation.Hotel.Models.Models;

namespace StayCation.Hotel.Core.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public TransactionService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TransactionDto>> GetAllTransactionsAsync()
        {
            var transaction = await _unitOfWork.TransactionRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<TransactionDto>>(transaction);
        }

        public async Task<TransactionDto> GetTransactionByIdAsync(string Id)
        {
            var transaction = await _unitOfWork.TransactionRepository.GetAsync(x => x.Id ==Id);
            return _mapper.Map<TransactionDto>(transaction);
        }

        public async Task AddTransactionsAsync(TransactionDto transaction)
        {
            var transactions = _mapper.Map<Transaction>(transaction);
            await _unitOfWork.TransactionRepository.AddAsync(transactions);
            await _unitOfWork.Save();
        }
    }
}
