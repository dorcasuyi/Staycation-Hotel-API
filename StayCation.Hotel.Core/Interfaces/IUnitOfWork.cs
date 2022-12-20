using StayCation.Hotel.Models.Models;

namespace StayCation.Hotel.Core.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        IBlogRepository BlogRepository { get; }
        ICategoryRepository CaterogryRepository { get; }
        IDetailsRepository DetailsRepository { get; }
        IGenericRepository<HotelAccount> HotelAccountRepository { get; }
        IHotelRepository HotelsRepository { get; }
        IImageRepository ImageRepository { get; }
        ILocationRepository LocationRepository { get; }
        IPaymentRepository PaymentRepository { get; }
        IGenericRepository<Role> RoleRepository { get; }
        ITransactionRepository TransactionRepository { get; }
        IUserRepository UserRepository { get; }
        IBookingRepository BookingRepository { get; }

        Task Save();
    }
}