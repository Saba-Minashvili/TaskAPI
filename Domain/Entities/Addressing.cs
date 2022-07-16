namespace Domain.Entities
{
    public class Addressing : BaseEntity
    {
        public int RegionId { get; set; }
        public int MunicipalId { get; set; }
        public int CityId { get; set; }
        public int UnityId { get; set; }
        public int VillageId { get; set; }

        public string? District { get; set; }
        public string? Mr { get; set; }
        public string? Quarter { get; set; }
        public string? Street { get; set; }
        public string? Building { get; set; }
        public string? Corpus { get; set; }
        public int FlatNum { get; set; }

        public int BuildingType { get; set; }

        public string? InstitutionName { get; set; }
        public int InstitutionSpaceNum { get; set; }

        public int LivingStatus { get; set; }

        public List<HouseHold>? HouseHold { get; set; }
    }
}
