using AutoMapper;
using Contracts;
using Domain.Entities;
using Domain.Repositories;
using Services.Abstractions;

namespace Services
{
    internal sealed class AddressingService : IAddressingService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AddressingService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AddressingDto>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var addressings = await _unitOfWork.AddressingRepository.GetAllAsync(cancellationToken);

            var addressingsDto = _mapper.Map<IEnumerable<AddressingDto>>(addressings);

            return addressingsDto;
        }

        public async Task<AddressingDto> GetByIdAsync(int addressingId, CancellationToken cancellationToken = default)
        {
            var addressing = await _unitOfWork.AddressingRepository.GetByIdAsync(addressingId, cancellationToken);

            var addressingDto = _mapper.Map<AddressingDto>(addressing);

            return addressingDto;
        }

        public async Task<AddressingDto> CreateAsync(AddressingDto addressingDto, CancellationToken cancellationToken = default)
        {
            if (addressingDto == null)
            {
                throw new ArgumentNullException(nameof(addressingDto));
            }

            var addressing = _mapper.Map<Addressing>(addressingDto);

            _unitOfWork.AddressingRepository.CreateAsync(addressing);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return addressingDto;
        }

        public async Task DeleteAsync(int addressingId, CancellationToken cancellationToken = default)
        {
            if(addressingId == 0)
            {
                throw new ArgumentNullException(nameof(addressingId));
            }

            var addressing = await _unitOfWork.AddressingRepository.GetByIdAsync(addressingId, cancellationToken);

            _unitOfWork.AddressingRepository.DeleteAsync(addressing);

            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task UpdateAsync(int addressingId, UpdateAddressingDto updateAddressingDto, CancellationToken cancellationToken = default)
        {
            if (updateAddressingDto == null)
            {
                throw new ArgumentNullException(nameof(updateAddressingDto));
            }

            var addressing = await _unitOfWork.AddressingRepository.GetByIdAsync(addressingId, cancellationToken);

            addressing.CityId = updateAddressingDto.CityId;
            addressing.UnityId = updateAddressingDto.UnityId;
            addressing.RegionId = updateAddressingDto.RegionId;
            addressing.VillageId = updateAddressingDto.VillageId;
            addressing.MunicipalId = updateAddressingDto.MunicipalId;

            addressing.District = updateAddressingDto.District;
            addressing.Mr = updateAddressingDto.Mr;
            addressing.Quarter = updateAddressingDto.Quarter;
            addressing.Street = updateAddressingDto.Street;
            addressing.Building = updateAddressingDto.Building;
            addressing.Corpus = updateAddressingDto.Corpus;
            addressing.FlatNum = updateAddressingDto.FlatNum;

            addressing.BuildingType = updateAddressingDto.BuildingType;

            addressing.InstitutionSpaceNum = updateAddressingDto.InstitutionSpaceNum;
            addressing.InstitutionName = updateAddressingDto.InstitutionName;

            addressing.LivingStatus = updateAddressingDto.LivingStatus;

            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}
