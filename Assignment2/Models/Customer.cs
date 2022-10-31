using System.ComponentModel.DataAnnotations;

namespace Assignment2.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string? CustomerFirstname { get; set; }
        public string? CustomerLastname { get; set; }
        public string? CustomerLocation { get; set; }
        
        //relationships
        public int? CompanyID { get; set; }
        public int? TravelAgencyID { get; set; }

    }
}
