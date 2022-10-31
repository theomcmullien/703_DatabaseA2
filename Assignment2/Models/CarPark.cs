using System.ComponentModel.DataAnnotations;

namespace Assignment2.Models
{
    public class CarPark
    {
        [Key]
        public int CarParkID { get; set; }
        public string? CarParkCode { get; set; }
        public bool CarParkIsAvailable { get; set; }

    }
}
