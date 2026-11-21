namespace GymG01.Entities
{
    public class Session : BaseEntity
    {
        internal object CreatedAt;

        public string Description { get; set; } = default!;
        public int Capacity { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int TrainerId { get; set; } // FK
        public Trainer Trainer { get; set; } = default!;
    }
}
