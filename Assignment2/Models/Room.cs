using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment2.Models
{
    public class Room
    {
        [Key]
        public int RoomID { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal RoomDailyCost { get; set; }
        public string? RoomType { get; set; }
        public string? RoomStatus { get; set; }

        //relationships
        public int HotelID { get; set; }

    }
}
