using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
    //Guest class for hotel guests. I had tried to tie a Reservation to this class, but there was conflicting Foreign Key issues and I was never able to get it to work. 
    class Guest
    {
        [Key]
        public int GuestId { get; set; }
        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public double AmountDue { get; set; }
        public bool BillPaid { get; set; }
        [Required]
        public int NightsStaying { get; set; }

        public virtual Hotel Hotel { get; set; }

        //public virtual List<Reservation> Reservations { get; set; }

        //Basic ToString returning all fields with a new line after each field. 
        public override string ToString()
        {
            return ("Guest Id: " + GuestId +
                "\r\nName: " + FirstName + " " + LastName +
                "\r\nPhone Number: " + PhoneNumber +
                "\r\nEmail: " + Email +
                "\r\nBill Paid: " + BillPaid +
                "\r\nNights: " + NightsStaying +
                "\r\nAmount Due: " + AmountDue);
                //"\r\nHotel: " + Hotel.HotelName);
                //"\r\nReservation Id: " + Reservation.ReservationId);
        }
    }
}

