namespace GymG01.Entities
{
    public class Trainer : GymUser
    {
        public Specaity specailty {  get; set; }
        public ICollection<Session> Sessions { get; set; } = default!;
    }
}
