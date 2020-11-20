namespace Hand_In_2.Data.Persistance
{
    public class UnitOfWork
    {
        private IUserRepository _userRepository;
        private IAdultsRepository _adultsRepository;
        private ExampleDBContext _context;

        public UnitOfWork(ExampleDBContext context)
        {
            _context = context;
        }

        public IUserRepository UserRepo
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(_context);
                }
                return _userRepository;
            }
        }

        public IAdultsRepository AdultRepo
        {
            get
            {
                if (_adultsRepository == null)
                {
                    _adultsRepository = new AdultsRepository(_context);
                }

                return _adultsRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}