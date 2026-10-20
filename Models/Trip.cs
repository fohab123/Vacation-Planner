using System.ComponentModel.DataAnnotations.Schema;

namespace VacationPlanner.Models
{
    public class Trip
    {
        public int Id { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; } = null!;
        public string Name { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Budget { get; set; }
        public int People { get; set; }
        public bool Visited{ get; set; }
        public string Description { get; set; } = string.Empty;
        public ICollection<Destination> Destinations { get; set; } = new List<Destination>();
    }
}
