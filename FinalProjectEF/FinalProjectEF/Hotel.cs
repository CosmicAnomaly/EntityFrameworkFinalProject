using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Scott Robinson
 * .Net Final Project
 * Spring 2017
 */
namespace FinalProjectEF
{
    //Hotel class for storing hotels. The idea is that this is a chain business with numerous hotels of different layouts. 
    class Hotel
    {
        [Key]
        public int HotelId { get; set; }
        [Required]
        public bool Vacancy { get; set; }
        [Required]
        [MaxLength(30)]
        public string HotelName { get; set; }
        [Required]
        public string HotelPhone { get; set; }
        [Required]
        public string HotelCity { get; set; }
        [Required]
        [MaxLength(20)]
        public string HotelState { get; set; }
        [Required]
        [MaxLength(8)]
        public string HotelZip { get; set; }
        [Required]
        public int RoomCount { get; set; }
        [Required]
        public bool Pool { get; set; }
        [Required]
        public bool BanquetHall { get; set; }

        public virtual List<Reservation> Reservations { get; set; }

        public override string ToString()
        {
            return ("Hotel Id: " + HotelId +
                "\r\nVacancy: " + Vacancy +
                "\r\nHotel Name: " + HotelName +
                "\r\nHotel Phone: " + HotelPhone +
                "\r\nHotel City: " + HotelCity +
                "\r\nHotel State: " + HotelState +
                "\r\nHotel Zip: " + HotelZip +
                "\r\nRoom Count: " + RoomCount +
                "r\nPool: " + Pool +
                "\r\nBanquet Hall: " + BanquetHall);
        }
    }
}
