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
    //Class for reservations, I initially hadn't planned for this class but the idea came to me later that it's a good way to tied tables together. 
    class Reservation
    {
        [Key]
        public int ReservationId { get; set; }
        public virtual Hotel Hotel { get; set; }
        public virtual Guest Guest { get; set; }
        public virtual Room Room { get; set; }
        public double AmountDue { get; set; }

        public Reservation(Hotel hotel, Guest guest, Room room, double amountDue)
        {
            Hotel = hotel;
            Guest = guest;
            Room = room;
            AmountDue = amountDue;
        }

        public Reservation()
        { }
    }
}
