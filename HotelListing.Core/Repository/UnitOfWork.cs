using HotelListing.Core.IRepository;
using HotelListing.Data;

namespace HotelListing.Core.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataBaseContext context;
        private IGenericRepository<Hotel> _hotels;
        private IGenericRepository<Country> _countries;

        public UnitOfWork(DataBaseContext context)
        {
            this.context = context;
        }

        public IGenericRepository<Country> Countries => _countries ??= new GenericRepository<Country>(context);

        public IGenericRepository<Hotel> Hotels => _hotels ??= new GenericRepository<Hotel>(context);

        public void Dispose()
        {
            context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await context.SaveChangesAsync();
        }
    }
}
