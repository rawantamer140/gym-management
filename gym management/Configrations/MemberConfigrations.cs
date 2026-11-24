using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using gym_management.Entities;


namespace gym_management.Configrations
{
    public class MemberConfigrations: GymuserConfigrations<Member>, IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("getdate()").HasColumnName(" joinDate()");


        }

    }
}
