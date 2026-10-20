using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using VacationPlanner.Models;

namespace VacationPlanner.Models
{
    public class Hotel
    {
        public int Id { get; set; }

        [ForeignKey("Destination")]
        public int DestinationId { get; set; }
        public Destination Destination { get; set; } = null!;
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Stars { get; set; }
        public int Capacity { get; set; }
        public double Rating { get; set; }


    }
}
