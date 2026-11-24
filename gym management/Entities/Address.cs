namespace gym_management.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public int BuildingNumber { get; set; }

        public string city { get; set; } = default!;

        public string Street { get; set; } = default!;



    }
}
