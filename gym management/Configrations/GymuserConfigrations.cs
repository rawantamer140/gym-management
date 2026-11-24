using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using gym_management.Entities;


namespace gym_management.Configrations
{
    // gym user not a table in the database so we will not create a configuration for it 
    //
    public class GymuserConfigrations<T> : IEntityTypeConfiguration<T> where T : GymUser
    {

        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.Name).HasColumnType("varchar").HasMaxLength(50);

            builder.Property(x => x.PhoneNumber).HasMaxLength(11).HasColumnType("varchar");

            builder.HasIndex(x => x.Email).IsUnique();
            builder.HasIndex(x => x.PhoneNumber).IsUnique();

            builder.ToTable(T =>
            {
                T.HasCheckConstraint(" GYMUSER_EMAILCHEK", "Email Like '_%@_%._%'");
                T.HasCheckConstraint(" GYMUSER_PHONECHECK ", "LEN(phone)=11  AND (phone LIKE'010%' OR phone LIKE '011%'  OR phone LIke '012%'   OR phone LIke '015%'   ");
            });

            builder.ComplexProperty(x => x.Address); //composite attribute


        }
    }
}
