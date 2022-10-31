using System.ComponentModel.DataAnnotations;

namespace Assignment2.Models
{
    public class TravelAgency
    {
        [Key]
        public int TravelAgencyID { get; set; }
        public string? TravelAgencyName { get; set; }
        public string? TravelAgencyEmail { get; set; }
        public string? TravelAgencyPhone { get; set; }

    }
}
