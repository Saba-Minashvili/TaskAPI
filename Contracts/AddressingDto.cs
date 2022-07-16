using System.ComponentModel.DataAnnotations;

namespace Contracts
{
    public class AddressingDto
    {
        public int Id { get; set; }
        public int RegionId { get; set; }
        public int MunicipalId { get; set; }
        public int CityId { get; set; }
        public int UnityId { get; set; }
        public int VillageId { get; set; }

        [Required]
        public string? District { get; set; }
        [Required]
        public string? Mr { get; set; }
        [Required]
        public string? Quarter { get; set; }
        [Required]
        public string? Street { get; set; }
        [Required]
        public string? Building { get; set; }
        [Required]
        public string? Corpus { get; set; }
        [Required]
        public int FlatNum { get; set; }
        [Required]

        public int BuildingType { get; set; }

        [Required]
        public string? InstitutionName { get; set; }
        [Required]
        public int InstitutionSpaceNum { get; set; }

        [Required]
        public int LivingStatus { get; set; }

        [Required]
        public List<HouseHoldDto>? HouseHold { get; set; }
    }
}
