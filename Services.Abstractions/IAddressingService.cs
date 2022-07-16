using Contracts;

namespace Services.Abstractions
{
    public interface IAddressingService
    {
        Task<IEnumerable<AddressingDto>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<AddressingDto> GetByIdAsync(int addressingId, CancellationToken cancellationToken = default);
        Task<AddressingDto> CreateAsync(AddressingDto addressingDto, CancellationToken cancellationToken = default);
        Task UpdateAsync(int addressingId, UpdateAddressingDto updateAddressingDto, CancellationToken cancellationToken = default);
        Task DeleteAsync(int addressingId, CancellationToken cancellationToken = default);
    }
}
