using AutoMapper;
using Domain.Repositories;
using Services.Abstractions;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IAddressingService> _addressingService;

        public ServiceManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _addressingService = new Lazy<IAddressingService>(() => new AddressingService(unitOfWork, mapper));
        }

        public IAddressingService AddressingService => _addressingService.Value;
    }
}
