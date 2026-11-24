namespace gym_management.Entities
{
    public  abstract class BaseEntity
    {


        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

    }
}
