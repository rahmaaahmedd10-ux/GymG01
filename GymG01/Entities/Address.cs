using Microsoft.EntityFrameworkCore;

namespace GymG01.Entities
{
    [Owned]
    public class Address
    {
        public string Street { get; set; } = default!;
        public string Country { get; set; } = default!;
        public int BuildingNumber { get; set; }
    }
}