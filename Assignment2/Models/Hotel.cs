using System.ComponentModel.DataAnnotations;

namespace Assignment2.Models
{
    public class Hotel
    {
        [Key]
        public int HotelID { get; set; }
        public string? HotelName { get; set; }
        public string? HotelCity { get; set; }
        public string? HotelSuburb { get; set; }
        public string? HotelAddress { get; set; }

    }
}
