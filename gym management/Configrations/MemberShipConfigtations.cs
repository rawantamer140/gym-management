using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using gym_management.Entities;



namespace gym_management.Configrations
{
    public class MemberShipConfigtations : IEntityTypeConfiguration<MemberShip>
    {

        public void Configure(EntityTypeBuilder<MemberShip> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("getdate()");
            builder.HasOne(x => x.Plan).WithMany(x => x.PlanSubscriptions).HasForeignKey(x => x.PlanId).OnDelete(DeleteBehavior.Restrict);



            builder.HasOne(x => x.Member).WithMany(x => x.MemberSubscriptions).HasForeignKey(x => x.MemberId).OnDelete(DeleteBehavior.Restrict);
        }


    }
}
