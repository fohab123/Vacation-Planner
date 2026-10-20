using System.ComponentModel.DataAnnotations.Schema;
namespace VacationPlanner.Models
{
    public class Destination
    {
        public int Id { get; set; }

        [ForeignKey("Trip")]
        public int TripId { get; set; }
        public Trip Trip { get; set; } = null!;
        public string Name { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public ICollection<Hotel> Hotels { get; set; } = new List<Hotel>();
        public ICollection<Apartment> Apartments { get; set; } = new List<Apartment>();
    }
}
