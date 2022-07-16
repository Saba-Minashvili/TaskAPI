using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
    internal sealed class AddressingRepository:IAddressingRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public AddressingRepository(ApplicationDbContext dbContext) => _dbContext = dbContext;

        public async Task<IEnumerable<Addressing>> GetAllAsync(CancellationToken cancellationToken = default)
        {
#pragma warning disable CS8604 // Possible null reference argument.
            return await _dbContext.Addressing
                .Include(o => o.HouseHold)
                .ToListAsync(cancellationToken);
#pragma warning restore CS8604 // Possible null reference argument.
        }

        public async Task<Addressing> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
#pragma warning disable CS8603 // Possible null reference return.
#pragma warning disable CS8604 // Possible null reference argument.
            return await _dbContext.Addressing
                .Include(o => o.HouseHold)
                .FirstOrDefaultAsync(o => o.Id == id, cancellationToken);
#pragma warning restore CS8604 // Possible null reference argument.
#pragma warning restore CS8603 // Possible null reference return.
        }

        public void CreateAsync(Addressing addressing)
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            _dbContext.Addressing.Add(addressing);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }

        public void UpdateAsync(int id, Addressing addressing)
        {
            addressing.Id = id;
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            _dbContext.Addressing.Update(addressing);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }

        public void DeleteAsync(Addressing addressing)
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            _dbContext.Addressing.Remove(addressing);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }
    }
}
