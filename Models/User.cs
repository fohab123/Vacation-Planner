using Microsoft.AspNetCore.Identity;

namespace VacationPlanner.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public ICollection<Trip> Trips { get; set; } = new List<Trip>();
    }
}
