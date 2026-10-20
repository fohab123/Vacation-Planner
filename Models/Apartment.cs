using System.ComponentModel.DataAnnotations.Schema;

namespace VacationPlanner.Models
{
    public class Apartment
    {

        public int Id { get; set; }
        [ForeignKey("Destination")]
        public int DestinationId { get; set; }
        public Destination Destination { get; set; } = null!;
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public int Capacity { get; set; }
        public int Bedrooms { get; set; }
        public double Rating { get; set; }


    }
}
