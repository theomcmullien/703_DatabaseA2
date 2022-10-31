using System.ComponentModel.DataAnnotations;

namespace Assignment2.Models
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }
        public string BookingStartDate { get; set; }
        public string BookingEndDate { get; set; }
        public bool BookingIsPaid { get; set; }
        public string? BookingCardNumber { get; set; }
        public string? BookingCardExiryDate { get; set; }
        public string? BookingCardCCV { get; set; }
        public bool HasCarPark { get; set; }

        //relationships
        public string CustomerID { get; set; }
        public int RoomID { get; set; }

    }
}
