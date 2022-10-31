using System.ComponentModel.DataAnnotations;

namespace Assignment2.Models
{
    public class Company
    {
        [Key]
        public int CompanyID { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyEmail { get; set; }
        public string? CompanyPhone { get; set; }

    }
}
