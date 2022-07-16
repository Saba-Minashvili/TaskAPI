namespace Domain.Entities
{
    public class HouseHold : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? FatherName { get; set; }
        public int MembersNum { get; set; }
        public string? MobileNum { get; set; }

        // FK for addressing entity
        public int AddressingId { get; set; }
    }
}
