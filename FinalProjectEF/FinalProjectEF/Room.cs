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
    //Class for Rooms, the ToString never quite worked out how I had intended. But it works well enough. 
    class Room
    {
        [Key]
        public int RoomNumber { get; set; }
        [Required]
        public string RoomType { get; set; }
        [Required]
        public double RoomRate { get; set; }
        [Required]
        public int QueenBed { get; set; }
        [Required]
        public int KingBed { get; set; }
        [Required]
        public int TwinBed { get; set; }
        [Required]
        public bool Jacuzzi { get; set; }
        [Required]
        public bool MiniBar { get; set; }
        [Required]
        public bool Kitchen { get; set; }
        [Required]
        public bool CouchBed { get; set; }
        [Required]
        public int Television { get; set; }
        [Required]
        public bool Safe { get; set; }

        public virtual List<Reservation> Reservations { get; set; }

        //Basic ToString with some thrown in if statements.
        //Due to the amount of variables assigned to a Room, no ToString should display a field that is 0 or false.
        public override string ToString()
        {
            if (QueenBed < 1)
            {
                return ("Room Number: " + RoomNumber +
                    "\r\nRoom Type: " + RoomType +
                    "\r\nRoom Rate: " + RoomRate +
                    "\r\nKing Beds: " + KingBed +
                    "\r\nTwin Beds: " + TwinBed +
                    "\r\nJacuzzi: " + Jacuzzi +
                    "\r\nMini Fridge: " + MiniBar +
                    "\r\nKitchen: " + Kitchen +
                    "\r\nCouch Bed: " + CouchBed +
                    "\r\nTelevision: " + Television +
                    "\r\nSafe: " + Safe);
            }

            if (KingBed < 1)
            {
                return ("Room Number: " + RoomNumber +
                    "\r\nRoom Type: " + RoomType +
                    "\r\nRoom Rate: " + RoomRate +
                    "\r\nQueen Beds: " + QueenBed +
                    "\r\nTwin Beds: " + TwinBed +
                    "\r\nJacuzzi: " + Jacuzzi +
                    "\r\nMini Fridge: " + MiniBar +
                    "\r\nKitchen: " + Kitchen +
                    "\r\nCouch Bed: " + CouchBed +
                    "\r\nTelevision: " + Television +
                    "\r\nSafe: " + Safe);
            }

            if (TwinBed < 1)
            {
                return ("Room Number: " + RoomNumber +
                    "\r\nRoom Type: " + RoomType +
                    "\r\nRoom Rate: " + RoomRate +
                    "\r\nQueen Beds: " + QueenBed +
                    "\r\nKing Beds: " + KingBed +
                    "\r\nJacuzzi: " + Jacuzzi +
                    "\r\nMini Fridge: " + MiniBar +
                    "\r\nKitchen: " + Kitchen +
                    "\r\nCouch Bed: " + CouchBed +
                    "\r\nTelevision: " + Television +
                    "\r\nSafe: " + Safe);
            }

            if (!Jacuzzi)
            {
                return ("Room Number: " + RoomNumber +
                    "\r\nRoom Type: " + RoomType +
                    "\r\nRoom Rate: " + RoomRate +
                    "\r\nQueen Beds: " + QueenBed +
                    "\r\nKing Beds: " + KingBed +
                    "\r\nTwin Beds: " + TwinBed +
                    "\r\nMini Fridge: " + MiniBar +
                    "\r\nKitchen: " + Kitchen +
                    "\r\nCouch Bed: " + CouchBed +
                    "\r\nTelevision: " + Television +
                    "\r\nSafe: " + Safe);
            }

            if (!MiniBar)
            {
                return ("Room Number: " + RoomNumber +
                    "\r\nRoom Type: " + RoomType +
                    "\r\nRoom Rate: " + RoomRate +
                    "\r\nQueen Beds: " + QueenBed +
                    "\r\nKing Beds: " + KingBed +
                    "\r\nTwin Beds: " + TwinBed +
                    "\r\nJacuzzi: " + Jacuzzi +
                    "\r\nKitchen: " + Kitchen +
                    "\r\nCouch Bed: " + CouchBed +
                    "\r\nTelevision: " + Television +
                    "\r\nSafe: " + Safe);
            }

            if (!Kitchen)
            {
                return ("Room Number: " + RoomNumber +
                    "\r\nRoom Type: " + RoomType +
                    "\r\nRoom Rate: " + RoomRate +
                    "\r\nQueen Beds: " + QueenBed +
                    "\r\nKing Beds: " + KingBed +
                    "\r\nTwin Beds: " + TwinBed +
                    "\r\nJacuzzi: " + Jacuzzi +
                    "\r\nMini Fridge: " + MiniBar +
                    "\r\nCouch Bed: " + CouchBed +
                    "\r\nTelevision: " + Television +
                    "\r\nSafe: " + Safe);
            }

            if (!CouchBed)
            {
                return ("Room Number: " + RoomNumber +
                    "\r\nRoom Type: " + RoomType +
                    "\r\nRoom Rate: " + RoomRate +
                    "\r\nQueen Beds: " + QueenBed +
                    "\r\nKing Beds: " + KingBed +
                    "\r\nTwin Beds: " + TwinBed +
                    "\r\nJacuzzi: " + Jacuzzi +
                    "\r\nMini Fridge: " + MiniBar +
                    "\r\nKitchen: " + Kitchen +
                    "\r\nTelevision: " + Television +
                    "\r\nSafe: " + Safe);
            }

            if (!Safe)
            {
                return ("Room Number: " + RoomNumber +
                    "\r\nRoom Type: " + RoomType +
                    "\r\nRoom Rate: " + RoomRate +
                    "\r\nQueen Beds: " + QueenBed +
                    "\r\nKing Beds: " + KingBed +
                    "\r\nTwin Beds: " + TwinBed +
                    "\r\nJacuzzi: " + Jacuzzi +
                    "\r\nMini Fridge: " + MiniBar +
                    "\r\nKitchen: " + Kitchen +
                    "\r\nCouch Bed: " + CouchBed +
                    "\r\nTelevision: " + Television);
            }
            else
            {
                return ("Room Number: " + RoomNumber +
                    "\r\nRoom Type: " + RoomType +
                    "\r\nRoom Rate: " + RoomRate +
                    "\r\nQueen Beds: " + QueenBed +
                    "\r\nKing Beds: " + KingBed +
                    "\r\nTwin Beds: " + TwinBed +
                    "\r\nJacuzzi: " + Jacuzzi +
                    "\r\nMini Fridge: " + MiniBar +
                    "\r\nKitchen: " + Kitchen +
                    "\r\nCouch Bed: " + CouchBed +
                    "\r\nTelevision: " + Television +
                    "\r\nSafe: " + Safe);
            }
        }
    }
}

