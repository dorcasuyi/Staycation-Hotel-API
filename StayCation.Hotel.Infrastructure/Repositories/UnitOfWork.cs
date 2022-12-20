using StayCation.Hotel.Core.Interfaces;
using StayCation.Hotel.Models.Models;


namespace StayCation.Hotel.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HotelDbContext _dbContext;
        private IBlogRepository _blogRepository;
        private IBookingRepository _bookingRepository;
        private ICategoryRepository _categoryRepository;
        private IDetailsRepository _detailRepository;
        private IGenericRepository<HotelAccount> _hotelAccountRepository;
        private IHotelRepository _hotelsRepository;
        private IImageRepository _imageRepository;
        private ILocationRepository _locationRepository;
        private IPaymentRepository _paymentRepository;
        private IGenericRepository<Role> _roleRepository;
        private ITransactionRepository _transactionRepository;
        private IUserRepository _userRepository;
        public UnitOfWork(HotelDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IBlogRepository BlogRepository
        {
            get
            {
                if (_bookingRepository == null)
                {
                    _blogRepository = new BlogRepository(_dbContext);
                }
                return _blogRepository;
            }
        }
        public IBookingRepository BookingRepository
        {
            get
            {
                if (_bookingRepository == null)
                {
                    _bookingRepository = new BookingRepository(_dbContext);
                }
                return _bookingRepository;
            }
        }
        public ICategoryRepository CaterogryRepository
        {
            get
            {
                if (_categoryRepository == null)
                {
                    _categoryRepository = new CategoryRepository(_dbContext);
                }
                return _categoryRepository;
            }
        }
        public IDetailsRepository DetailsRepository
        {
            get
            {
                if (_detailRepository == null)
                {
                    _detailRepository = new DetailsRepository(_dbContext);
                }
                return _detailRepository;
            }
        }



        public IGenericRepository<HotelAccount> HotelAccountRepository
        {
            get
            {
                if (_hotelAccountRepository == null)
                {
                    _hotelAccountRepository = new GenericRepository<HotelAccount>(_dbContext);
                }
                return _hotelAccountRepository;
            }
        }

        public IHotelRepository HotelsRepository
        {
            get
            {
                if (_hotelsRepository == null)
                {
                    _hotelsRepository = new HotelRepository(_dbContext);
                }
                return _hotelsRepository;
            }
        }

        public IImageRepository ImageRepository
        {
            get
            {
                if (_imageRepository == null)
                {
                    _imageRepository = new ImageRepository(_dbContext);
                }
                return _imageRepository;
            }
        }
        public ILocationRepository LocationRepository
        {
            get
            {
                if (_locationRepository == null)
                {
                    _locationRepository = new LocationRepository(_dbContext);
                }
                return _locationRepository;
            }
        }
        public IPaymentRepository PaymentRepository
        {
            get
            {
                if (_paymentRepository == null)
                {
                    _paymentRepository = new PaymentRepository(_dbContext);
                }
                return _paymentRepository;
            }
        }
        public IGenericRepository<Role> RoleRepository
        {
            get
            {
                if (_roleRepository == null)
                {
                    _roleRepository = new GenericRepository<Role>(_dbContext);
                }
                return _roleRepository;
            }
        }
        public ITransactionRepository  TransactionRepository
        {
            get
            {
                if (_transactionRepository == null)
                {
                    _transactionRepository = new TransactionRepository(_dbContext);
                }
                return _transactionRepository;
            }
        }
        public IUserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(_dbContext);
                }
                return _userRepository;
            }
        }

        public async Task Save()
        {
            await _dbContext.SaveChangesAsync();
        }


        void IDisposable.Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
