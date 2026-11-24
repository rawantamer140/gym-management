namespace gym_management.Entities
{
    public class Session : BaseEntity
    {

        public string Description { get; set; } = default!;

        public int Capacity { get; set; }


        public DateTime StartDate { get; set; }


        //public int Id { get; set; }

        //public DateTime CreatedAt { get; set; }

        //public DateTime? UpdatedAt { get; set; }


        public DateTime EndDate { get; set; }



        // relationships ==========================

        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; } = default!;

    }
}
