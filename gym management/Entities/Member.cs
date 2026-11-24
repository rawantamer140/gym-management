using gym_management.Entities.Enums;

namespace gym_management.Entities
{
    public class Member : GymUser
    {

        //public string Name { get; set; } = default!;

        //public string Email { get; set; } = default!;

        //public string PhoneNumber { get; set; } = default!;


        //public DateTime DateOfBirth { get; set; }

        //public Gender Gender { get; set; }

        //public Address Address { get; set; } = default!;

        public string? Photo { get; set; }


        // Relationships ==========================

        public ICollection<MemberShip> MemberSubscriptions { get; set; } = default!;
    }
}
