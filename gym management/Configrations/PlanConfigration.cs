using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using gym_management.Entities;

namespace gym_management.Configrations
{
    public class PlanConfigration : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            //make the CreatedAt property to have a default value of the current date and time when a new Plan is created
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("getdate()");

            
            //make the DurationDays property to have a check constraint that ensures the duration is between 1 and 365
            builder.ToTable(T =>
            {
               
                T.HasCheckConstraint("CK_Plan_Duration", "DurationDays between 1 and 365");
            });
        }
    }
}
