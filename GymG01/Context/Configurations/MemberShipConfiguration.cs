using GymG01.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymG01.Contexts.Configurations
{
    public class MemberShipConfiguration : IEntityTypeConfiguration<MemberShips>
    {
        public void Configure(EntityTypeBuilder<MemberShips> builder)
        {
            builder.HasKey(E => new { E.MemberId, E.PlanId });

            builder.Property<DateTime>("CreatedAt")
                   .HasDefaultValueSql("GETDATE()");
        }
    }

}