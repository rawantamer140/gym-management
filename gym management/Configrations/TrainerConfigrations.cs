
using gym_management.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using gym_management.Entities;

namespace gym_management.Configrations

{
    public class TrainerConfigrations : GymuserConfigrations<Trainer>, IEntityTypeConfiguration<Trainer>    
    {
        public new void Configure(EntityTypeBuilder<Trainer> builder)
        {


            builder.Property(x => x.CreatedAt).HasDefaultValueSql("getdate()");

            base.Configure(builder);


        }

    }
}
