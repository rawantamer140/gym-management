using gym_management.Entities.Enums;

namespace gym_management.Entities
{
    public class Trainer : GymUser
    {

        //public string Name { get; set; } = default!;
       
        //public string Email { get; set; } = default!;

        //public string PhoneNumber { get; set; } = default!;


        //public DateTime DateOfBirth { get; set; }

        //public Gender Gender { get; set; }

        //public Address Address { get; set; } = default!;

        public DateTime HireDate { get; set; }

        public Specialties Specialties { get; set; } = default!;


        // Relationships ==========================

        public ICollection<Session> Sessions { get; set; } = default!;



    }
}
