using Domain.Entities;

namespace Domain.Repositories
{
    public interface IAddressingRepository
    {
        Task<IEnumerable<Addressing>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<Addressing> GetByIdAsync(int id, CancellationToken cancellationToken = default);
        void CreateAsync(Addressing addressing);
        void UpdateAsync(int id, Addressing addressing);
        void DeleteAsync(Addressing addressing);
    }
}
