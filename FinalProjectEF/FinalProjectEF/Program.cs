using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Diagnostics;
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
    //I had originally had more grand designs in my head for this project. However, it turned out better than expected. 
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Context())
            {
                try
                {
                    ////Print all Guests
                    //Console.WriteLine("Print all Guests: ");
                    //foreach (Guest guest in context.guests)
                    //{
                    //    Console.WriteLine(guest.ToString() + "\r\n");
                    //}

                    ////Print all Hotels
                    //Console.WriteLine("Print all Hotels: ");
                    //foreach (Hotel hotels in context.hotels)
                    //{
                    //    Console.WriteLine(hotels.ToString() + "\r\n");
                    //}

                    ////Print all Staff
                    //Console.WriteLine("Print all Staff: ");
                    //foreach (Staff staff in context.staff)
                    //{
                    //    Console.WriteLine(staff.ToString() + "\r\n");
                    //}

                    ////Print all Rooms
                    //Console.WriteLine("Print all Rooms: ");
                    //foreach (Room rooms in context.HotelRooms)
                    //{
                    //    Console.WriteLine(rooms.ToString() + "\r\n");
                    //}

                    ////Print all Reservations
                    //Console.WriteLine("Print all Reservations: ");
                    //foreach (Reservation reservations in context.Reservations)
                    //{
                    //    Console.WriteLine(reservations.Hotel.HotelName);
                    //}

                    ////Query by reservation Id
                    //var test = from r in context.Reservations
                    //           where r.ReservationId == 5
                    //           select new
                    //           {
                    //               r.Hotel,
                    //               r.Guest,
                    //               r.Room,
                    //               r.AmountDue,
                    //           };

                    //Rather than just doing basic queries I decided to try and give the user something to do. 
                    //The idea is to run this once with the Initializer uncommented, then comment it out and re-run for interaction with the system and database. 
                    //The program starts off asking the user to identify themselves as staff or Guest. obviously this would have some validation or security behind it. 
                    //Just showing basic queries and adding and updating behind the scenes over validation. 
                    Console.Write("Please enter 1 for Employee functions or 2 for Guest services. ");
                    int choice = Convert.ToInt16(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            {
                                //Here we give the user options and take their imput, leading to a switch statement which goes down the staff or guest case.
                                Console.Write("Please enter your employee id: ");
                                int empId = Convert.ToInt16(Console.ReadLine());
                                Console.Write("Press 1 to view current pay. \r\n");
                                Console.Write("Press 2 to view vacation days. \r\n");
                                Console.Write("Press 3 to view hiring date. \r\n");
                                Console.Write("Press 4 to calculate pay using hours worked. \r\n");
                                Console.Write("Press 5 to view all reservations associated to a particular hotel. \r\n");
                                Console.Write("Press 6 to view a guests information by phone number. \r\n");
                                Console.Write("Press 7 to view all guests with outstanding bills. \r\n");
                                Console.Write("Press 8 to view all hotels with vacancy. \r\n");
                                Console.Write("Press 9 to view all rooms with at least 1 king bed. \r\n");

                                Console.Write("Selection: ");
                                int choice2 = Convert.ToInt16(Console.ReadLine());

                                var s = from sP in context.Staff
                                        where sP.StaffId == empId
                                        select sP;

                                switch (choice2)
                                {
                                        //Staff view for current pay. 
                                    case 1:
                                        {
                                            foreach (var staff in s)
                                            {
                                                if (staff.PayPerHour == 0)
                                                {
                                                    Console.WriteLine(String.Format("{0:C}", staff.Salary) + " Per week");
                                                }
                                                else
                                                {
                                                    Console.WriteLine(String.Format("{0:C}", staff.PayPerHour) + " Per hour");
                                                }
                                            }
                                            break;
                                        }
                                        //Staff view for current vacation days. 
                                    case 2:
                                        {
                                            foreach (var staff in s)
                                            {
                                                Console.Write("You currently have " + staff.VacationDays + " Vacation Days.");
                                            }
                                            break;
                                        }
                                        //Staff view for their hiring date. 
                                    case 3:
                                        {
                                            foreach (var staff in s)
                                            {
                                                Console.Write("Hiring Date: " + staff.DateHired);
                                            }
                                            break;
                                        }
                                        //Staff view to calculate or view next pay check. 
                                    case 4:
                                        {
                                            foreach (var staff in s)
                                                if (staff.PayPerHour == 0)
                                                {
                                                    Console.Write("Your wages for the next pay period will be: " + (String.Format("{0:C}", staff.calculateSalary(staff.Salary))));
                                                }
                                                else
                                                {
                                                    Console.Write("Please enter your hours worked: ");
                                                    int hours = Convert.ToInt16(Console.ReadLine());
                                                    Console.WriteLine("Your wages for the next pay period will be: " + (String.Format("{0:C}", staff.calculatePay(hours, staff.PayPerHour))));
                                                }

                                            break;
                                        }
                                        //Staff view to view all reservations at a specified hotel. 
                                    case 5:
                                        {
                                            Console.Write("Enter the Id of the hotel you wish to view reservations for. ");
                                            int hId = Convert.ToInt16(Console.ReadLine());
                                            var h = from hR in context.Reservations
                                                    where hR.Hotel.HotelId == hId
                                                    select new
                                                    {
                                                        hR.Guest,
                                                        hR.ReservationId,
                                                        hR.Hotel
                                                    };

                                            foreach (var var in h)
                                            {
                                                Console.WriteLine("Reservation Id: " + var.ReservationId + "\r\n"
                                                    + var.Guest);
                                            }
                                            break;
                                        }
                                        //Staff view to look up a guest by phone number.
                                        //Some data validation here, removes all special characters, and kicks back an error if anything other than numbers are entered. 
                                    case 6:
                                        {
                                            Console.Write("Enter the Phone Number of the Guest(no dashes or spaces): ");
                                            string phone = Console.ReadLine().ToLower();
                                            var characters = phone.Select(c =>
                                            {
                                                if (!char.IsNumber(c)) return ',';
                                                return c;
                                            }).ToArray();
                                            var phoneCheck = new string(characters);

                                            if (phoneCheck.ToLower().Contains(','))
                                            {
                                                Console.WriteLine("You did not enter a valid phone number. ");
                                            }
                                            else
                                            {
                                                var g = from gP in context.Guests
                                                        where gP.PhoneNumber.Equals(phoneCheck)
                                                        select new
                                                        {
                                                            gP.Hotel,
                                                            gP
                                                        };

                                                foreach (var guest in g)
                                                {
                                                    Console.Write(String.Format("Guest Id: {0}\r\nFirst Name: {1}\r\nLast Name: {2}\r\nHotel: {3}",
                                                                            guest.gP.GuestId, guest.gP.FirstName, guest.gP.LastName, guest.Hotel.HotelName));
                                                }
                                            }
                                            break;
                                        }
                                        //Staff view for all guests with outstanding bills. 
                                    case 7:
                                        {
                                            var oB = from oBill in context.Guests
                                                     where oBill.BillPaid == false
                                                     select oBill;
                                            foreach (var o in oB)
                                            {
                                                Console.WriteLine(o.ToString() + "Amount Due: " + o.AmountDue + "\r\n");
                                            }

                                            break;
                                        }
                                        //Staff view for all hotels that currently have vacancy. 
                                    case 8:
                                        {
                                            var hV = from hVac in context.Hotels
                                                     where hVac.Vacancy == true
                                                     select hVac;

                                            foreach (var hh in hV)
                                            {
                                                Console.WriteLine(hh.ToString() + "\r\n");
                                            }
                                            break;
                                        }
                                        //Staff view for rooms with at least 1 king bed. 
                                        //Many hotel concierges have the ability to filter rooms by contents. 
                                    case 9:
                                        {
                                            var hR = from hRKB in context.HotelRooms
                                                     where hRKB.KingBed > 0
                                                     select hRKB;

                                            foreach (var hRB in hR)
                                            {
                                                Console.WriteLine(hRB.ToString() + "\r\n");
                                            }
                                            break;
                                        }
                                }
                                break;
                            }
                            //Guest view beginning
                        case 2:
                            {
                                Console.Write("Welcome to the Hotel Reservation System for Guests!\n");
                                Console.Write("Press 1 to make a new reservation.\n");
                                Console.Write("Press 2 to view hotels with vacancy.\n");
                                Console.Write("Press 3 if you know your Id and you want to view your account.\n");
                                Console.Write("Press 4 to view and pay your bill.\n");
                                Console.Write("Selection: ");
                                int selection1 = Convert.ToInt16(Console.ReadLine());

                                switch (selection1)
                                {
                                    //Guest process to create new guest account and make a reservation. 
                                    case 1:
                                        {

                                            var r3 = from rR3 in context.HotelRooms
                                                    select rR3;

                                            var h3 = from h2h3 in context.Hotels
                                                     select h2h3;

                                            Console.Write("Please enter your first name: ");
                                            string firstName = Console.ReadLine();
                                            Console.Write("Please enter your last name: ");
                                            string lastName = Console.ReadLine();
                                            Console.Write("Please enter your phone number: ");
                                            string phone = Console.ReadLine();
                                            Console.Write("Please enter your email address: ");
                                            string email = Console.ReadLine();
                                            Console.Write("How many nights will you be staying: ");
                                            int nights = Convert.ToInt16(Console.ReadLine());

                                            foreach (var hotels in h3)
                                            {
                                                Console.WriteLine("Hotel Id:" + hotels.HotelId + "\r\nHotel Name: " + hotels.HotelName + "\r\n");
                                            }
                                            Console.Write("Enter the Id of the hotel: ");
                                            int hotel = Convert.ToInt16(Console.ReadLine());

                                            foreach (var rooms in r3)
                                            {
                                                Console.WriteLine("\r\nRoom Number: " + rooms.RoomNumber + "\r\nRate: " + rooms.RoomRate + "\r\nType: " + rooms.RoomType);
                                            }
                                            Console.Write("Enter the room number you would like: ");
                                            int room = Convert.ToInt16(Console.ReadLine());

                                            Guest guest1 = new Guest()
                                            {
                                                FirstName = firstName,
                                                LastName = lastName,
                                                PhoneNumber = phone,
                                                Email = email,
                                                BillPaid = false,
                                                NightsStaying = nights,
                                                AmountDue = 0.00
                                            };

                                            var r = from rR in context.HotelRooms
                                                    where rR.RoomNumber == room
                                                    select rR;

                                            var db = context.HotelRooms.FirstOrDefault(c => c.RoomNumber == room);

                                            var h2 = from h2h in context.Hotels
                                                     where h2h.HotelId == hotel
                                                     select h2h;

                                            var db2 = context.Hotels.FirstOrDefault(c => c.HotelId == hotel);

                                            foreach (var rV in r)
                                            {
                                                double roomRate = rV.RoomRate;
                                                double amountDue = roomRate * nights;

                                                Reservation res1 = new Reservation()
                                                {
                                                    Hotel = db2,
                                                    Guest = guest1,
                                                    Room = db,
                                                    AmountDue = amountDue
                                                };
                                                context.Reservations.Add(res1);
                                                guest1.AmountDue += res1.AmountDue;
                                                guest1.Hotel = db2;
                                                context.Guests.Add(guest1);
                                                
                                            }
                                            context.SaveChanges();

                                            Console.WriteLine("Thank you your reservation has been confirmed and a confirmation email will be sent shortly.");
                                            break;
                                        }
                                        //Guest view of hotels with vacancy. 
                                    case 2:
                                        {
                                            var hV = from hVac in context.Hotels
                                                     where hVac.Vacancy == true
                                                     select hVac;

                                            foreach (var hh in hV)
                                            {
                                                Console.WriteLine(hh.ToString() + "\r\n");
                                            }
                                            break;
                                        }
                                        //Guest view of their account details. 
                                    case 3:
                                        {
                                            Console.Write("Enter your Guest Id: ");
                                            int gId = Convert.ToInt16(Console.ReadLine());

                                            var g = from gu in context.Guests
                                                    where gu.GuestId == gId
                                                    select gu;

                                            foreach (var guest in g)
                                            {
                                                Console.WriteLine(guest.ToString() + guest.Hotel);
                                            }
                                            break;
                                        }
                                        //Guest view to pay bill and update amount due and bill paid status. 
                                    case 4:
                                        {
                                            Console.Write("Enter your Guest Id: ");
                                            int gId = Convert.ToInt16(Console.ReadLine());

                                            var g = from gu in context.Guests
                                                    where gu.GuestId == gId
                                                    select gu;

                                            var g2 = context.Guests.FirstOrDefault(b => b.GuestId == gId);

                                            foreach (var guest in g)
                                            {
                                                Console.WriteLine("Amount Due: " + (String.Format("{0:C}", guest.AmountDue)));
                                                Console.Write("Enter the amount you would like to pay: ");
                                                double payment = Convert.ToDouble(Console.ReadLine());

                                                if ((guest.AmountDue - payment) < 0)
                                                {
                                                    Console.Write("You have entered too much payment, you must restart. ");
                                                }
                                                if ((guest.AmountDue - payment) == 0)
                                                {
                                                    g2.AmountDue = 0.00;
                                                    g2.BillPaid = true;                                                   
                                                }
                                                else if ((guest.AmountDue - payment) > 0)
                                                {
                                                    double amountDue = Math.Round((guest.AmountDue - payment));
                                                    g2.AmountDue = amountDue;
                                                }
                                                Console.WriteLine("Your updated balance is: " + (String.Format("{0:C}", guest.AmountDue)));
                                            }
                                            context.SaveChanges();
                                            break;
                                        }
                                }

                                break;
                            }
                        default:
                            {
                                Console.WriteLine("You did not make a valid selection.");
                                break;
                            }
                    }
                }


                catch (DbEntityValidationException e)
                {
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Value: \"{1}\", Error: \"{2}\"",
                                ve.PropertyName,
                                eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName),
                                ve.ErrorMessage);
                        }
                    }
                    throw;
                }
            }
            Console.ReadLine();
        }
    }
}
