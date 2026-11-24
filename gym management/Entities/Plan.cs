namespace gym_management.Entities
{
    public class Plan : BaseEntity
    {
        public string Name { get; set; } = default!;


        public string Description { get; set; } = default!;


        public int DurationDays { get; set; }


        public decimal Price { get; set; }


        public bool IsActive { get; set; }


        // relationships ==========================

        public ICollection<MemberShip> PlanSubscriptions { get; set; } = default!;


    }
}
