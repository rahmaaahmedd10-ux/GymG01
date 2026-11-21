using System.ComponentModel.DataAnnotations.Schema;

namespace GymG01.Entities
{
    public class MemberShips
    {
        public int MemberId { get; set; }
        public Member Member { get; set; } = default!;
        public int PlanId { get; set; }
        public Plan Plan { get; set; } = default!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        // Not a Colom is in DataBase 
        [NotMapped]
        public string Status => StartDate > DateTime.Now ? "Upcoming"
                      : EndDate > DateTime.Now ? "Active"
                      : "Expired";
    }
}
