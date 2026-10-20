using System.ComponentModel.DataAnnotations.Schema;

namespace VacationPlanner.Models
{
    public class Transport
    {
        public int Id { get; set; }

        [ForeignKey("Destination")]
        public int DestinationId { get; set; }
        public Destination Destination { get; set; } = null!;
        public string Type { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;
        public string DepartureLocation { get; set; } = string.Empty;
        public string ArrivalLocation { get; set; } = string.Empty;
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public decimal Price { get; set; }
        public string Provider { get; set; } = string.Empty;
        public string BookingUrl { get; set; } = string.Empty;
    }
}
