using gym_management.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace gym_management.Configrations

{
    public class SessionConfigrationscs :IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(x=>x.CreatedAt).HasDefaultValueSql("getdate()");

            builder.ToTable(T =>
            {

                T.HasCheckConstraint("CK_Session_Capacity", "Capacity between 1 and 25");
                T.HasCheckConstraint("CK_Session_StartDateafterstartdate ", "EndDate > StartDate");
            });

            builder.HasOne(x => x.Trainer).WithMany(x => x.Sessions).HasForeignKey(x => x.TrainerId).OnDelete(DeleteBehavior.Restrict);

            
        }
      
    }
}
