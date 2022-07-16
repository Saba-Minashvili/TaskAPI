namespace Domain.Repositories
{
    public interface IUnitOfWork
    {
        public IAddressingRepository AddressingRepository { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
