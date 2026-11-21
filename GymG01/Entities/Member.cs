namespace GymG01.Entities
{
    public class Member : GymUser 
    {
      

        public string? Photo { get; set; }
        public ICollection<MemberShips> MemberSubScription { get; set; } = default!;
    }
}
