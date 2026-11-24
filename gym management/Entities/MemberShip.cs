using System.ComponentModel.DataAnnotations.Schema;

namespace gym_management.Entities
{
    public class MemberShip : BaseEntity
    {
        // her the primary key is --> id ---> that i inherited from base entity class




        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        // relationships with Member =======
        public int MemberId { get; set; }
        public Member Member { get; set; } = default!;


        //Relationship with Plan
        public int PlanId { get; set; }
        public Plan Plan { get; set; } = default!;


        // panid + memberid --> not composite primary key but unique key 
        // or planid + memberid + id ---> composite primary key  --> but it is  with 3 columns  not 2 columns 


        [NotMapped]
        public string Status => StartDate > DateTime.Now ? "Upcoming" : EndDate > DateTime.Now ? "Expired" : "Active";

    }
}