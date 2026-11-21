namespace GymG01.Entities
{
    public class Plan : BaseEntity
    {
        internal object CreatedAt;

        public string Name { get; set; } = default!;
        public decimal Price { get; set; }
        public string Description { get; set; } = default!;
        public int DurationDays { get; set; }
        public bool IsActive { get; set; }

        public ICollection<MemberShips>? PlanSubScription { get; set; }
    }

   
    }

