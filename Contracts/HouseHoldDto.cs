namespace Contracts
{
    public class HouseHoldDto
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? FatherName { get; set; }
        public int MembersNum { get; set; }
        public string? MobileNum { get; set; }

        public int AddressingId { get; set; }
    }
}
