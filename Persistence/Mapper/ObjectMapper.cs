using AutoMapper;
using Contracts;
using Domain.Entities;

namespace Persistence.Mapper
{
    public class ObjectMapper:Profile
    {
        public ObjectMapper()
        {
            CreateMap<Addressing, AddressingDto>()
                .ReverseMap();
            CreateMap<Addressing, UpdateAddressingDto>()
                .ReverseMap();
            CreateMap<HouseHold, HouseHoldDto>()
                .ReverseMap();
        }
    }
}
