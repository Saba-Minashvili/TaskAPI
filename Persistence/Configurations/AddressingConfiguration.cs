using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
