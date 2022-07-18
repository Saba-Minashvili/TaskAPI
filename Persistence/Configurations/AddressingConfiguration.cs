using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    internal sealed class AddressingConfiguration : IEntityTypeConfiguration<Addressing>
    {
        public void Configure(EntityTypeBuilder<Addressing> builder)
        {
            builder.HasMany(addressing => addressing.HouseHold)
                .WithOne()
                .HasForeignKey(houseHold => houseHold.AddressingId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
