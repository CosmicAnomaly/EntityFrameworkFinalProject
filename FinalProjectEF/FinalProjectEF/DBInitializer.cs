using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    //Database initializer class, this will hardcode data into the database upon the initial load.
    class DBInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            ////Hardcoding of initial data. Run once then comment out to only run queries. 
            //Hotel hotel1 = new Hotel()
            //{
            //    Vacancy = true,
            //    HotelName = "Luxor",
            //    HotelPhone = "4065559989",
            //    HotelCity = "Helena",
            //    HotelState = "Montana",
            //    HotelZip = "59602",
            //    RoomCount = 5,
            //    Pool = true,
            //    BanquetHall = true
            //};
            //context.Hotels.Add(hotel1);

            //Hotel hotel2 = new Hotel()
            //{
            //    Vacancy = true,
            //    HotelName = "Abarth Hotel",
            //    HotelPhone = "6235556566",
            //    HotelCity = "Phoenix",
            //    HotelState = "Arizona",
            //    HotelZip = "85086",
            //    RoomCount = 5,
            //    Pool = true,
            //    BanquetHall = true
            //};
            //context.Hotels.Add(hotel2);

            //Hotel hotel3 = new Hotel()
            //{
            //    Vacancy = true,
            //    HotelName = "The Tower Hotel",
            //    HotelPhone = "9585554121",
            //    HotelCity = "Seattle",
            //    HotelState = "Washington",
            //    HotelZip = "65225",
            //    RoomCount = 5,
            //    Pool = true,
            //    BanquetHall = true
            //};
            //context.Hotels.Add(hotel3);

            //Hotel hotel4 = new Hotel()
            //{
            //    Vacancy = true,
            //    HotelName = "Plaza Hotel",
            //    HotelPhone = "6525551515",
            //    HotelCity = "Portalnd",
            //    HotelState = "Oregon",
            //    HotelZip = "35221",
            //    RoomCount = 5,
            //    Pool = true,
            //    BanquetHall = true
            //};
            //context.Hotels.Add(hotel4);

            //Hotel hotel5 = new Hotel()
            //{
            //    Vacancy = true,
            //    HotelName = "The Deluxe Hotel",
            //    HotelPhone = "6565558741",
            //    HotelCity = "Las Vegas",
            //    HotelState = "Nevada",
            //    HotelZip = "65215",
            //    RoomCount = 6,
            //    Pool = true,
            //    BanquetHall = true
            //};
            //context.Hotels.Add(hotel5);
            //context.SaveChanges();

            //Staff staff1 = new Staff()
            //{
            //    FirstName = "Jack",
            //    LastName = "Ryan",
            //    PhoneNumber = "4065558393",
            //    Position = "Fixer",
            //    PayPerHour = 0,
            //    Salary = 900.00,
            //    VacationDays = 6,
            //    DateHired = new DateTime(2013, 4, 20, 12, 30, 00),
            //    EmployedCurrently = true,
            //    ReHirable = true
            //};
            //context.Staff.Add(staff1);

            //Staff staff2 = new Staff()
            //{
            //    FirstName = "Brian",
            //    LastName = "Madoff",
            //    PhoneNumber = "4065558785",
            //    Position = "Supervisor",
            //    PayPerHour = 0,
            //    Salary = 1500.00,
            //    VacationDays = 3,
            //    DateHired = new DateTime(2015, 6, 22, 12, 30, 00),
            //    EmployedCurrently = true,
            //    ReHirable = true
            //};
            //context.Staff.Add(staff2);

            //Staff staff3 = new Staff()
            //{
            //    FirstName = "Jessica",
            //    LastName = "Johnson",
            //    PhoneNumber = "4065557741",
            //    Position = "Housekeeping",
            //    PayPerHour = 12.50,
            //    Salary = 0,
            //    VacationDays = 2,
            //    DateHired = new DateTime(2017, 3, 21, 12, 30, 00),
            //    EmployedCurrently = true,
            //    ReHirable = true
            //};
            //context.Staff.Add(staff3);

            //Staff staff4 = new Staff()
            //{
            //    FirstName = "Billy",
            //    LastName = "Rickshaw",
            //    PhoneNumber = "4065558120",
            //    Position = "Concierge",
            //    PayPerHour = 15.00,
            //    Salary = 0,
            //    VacationDays = 3,
            //    DateHired = new DateTime(2015, 11, 15, 12, 30, 00),
            //    EmployedCurrently = true,
            //    ReHirable = true
            //};
            //context.Staff.Add(staff4);

            //Staff staff5 = new Staff()
            //{
            //    FirstName = "Roberta",
            //    LastName = "Gonzales",
            //    PhoneNumber = "4065558521",
            //    Position = "Chef",
            //    PayPerHour = 0,
            //    Salary = 1500.00,
            //    VacationDays = 10,
            //    DateHired = new DateTime(2010, 1, 18, 12, 30, 00),
            //    EmployedCurrently = true,
            //    ReHirable = true
            //};
            //context.Staff.Add(staff5);
            //context.SaveChanges();

            //Room room1 = new Room()
            //{
            //    RoomType = "Standard-Single",
            //    RoomRate = 69.99,
            //    QueenBed = 0,
            //    KingBed = 1,
            //    TwinBed = 0,
            //    Jacuzzi = false,
            //    MiniBar = false,
            //    Kitchen = false,
            //    CouchBed = false,
            //    Television = 2,
            //    Safe = false
            //};
            //context.HotelRooms.Add(room1);

            //Room room2 = new Room()
            //{
            //    RoomType = "Standard-Double",
            //    RoomRate = 89.99,
            //    QueenBed = 2,
            //    KingBed = 0,
            //    TwinBed = 0,
            //    Jacuzzi = false,
            //    MiniBar = false,
            //    Kitchen = false,
            //    CouchBed = false,
            //    Television = 2,
            //    Safe = false
            //};
            //context.HotelRooms.Add(room2);

            //Room room3 = new Room()
            //{
            //    RoomType = "Deluxe-Single",
            //    RoomRate = 109.99,
            //    QueenBed = 0,
            //    KingBed = 1,
            //    TwinBed = 0,
            //    Jacuzzi = false,
            //    MiniBar = true,
            //    Kitchen = true,
            //    CouchBed = true,
            //    Television = 3,
            //    Safe = true
            //};
            //context.HotelRooms.Add(room3);

            //Room room4 = new Room()
            //{
            //    RoomType = "Deluxe-Double",
            //    RoomRate = 119.99,
            //    QueenBed = 0,
            //    KingBed = 2,
            //    TwinBed = 0,
            //    Jacuzzi = false,
            //    MiniBar = true,
            //    Kitchen = true,
            //    CouchBed = true,
            //    Television = 3,
            //    Safe = true
            //};
            //context.HotelRooms.Add(room4);

            //Room room5 = new Room()
            //{
            //    RoomType = "Suite-Single",
            //    RoomRate = 199.00,
            //    QueenBed = 0,
            //    KingBed = 1,
            //    TwinBed = 0,
            //    Jacuzzi = true,
            //    MiniBar = true,
            //    Kitchen = true,
            //    CouchBed = true,
            //    Television = 5,
            //    Safe = true
            //};
            //context.HotelRooms.Add(room5);

            //Room room6 = new Room()
            //{
            //    RoomType = "Suite-Double",
            //    RoomRate = 219.99,
            //    QueenBed = 0,
            //    KingBed = 2,
            //    TwinBed = 1,
            //    Jacuzzi = true,
            //    MiniBar = true,
            //    Kitchen = true,
            //    CouchBed = true,
            //    Television = 6,
            //    Safe = true
            //};
            //context.HotelRooms.Add(room6);
            //context.SaveChanges();

            //Guest guest1 = new Guest()
            //{
            //    FirstName = "Bob",
            //    LastName = "Anderson",
            //    PhoneNumber = "4065557685",
            //    Email = "BA1945@hotmail.com",
            //    BillPaid = false,
            //    NightsStaying = 1,
            //    AmountDue = 0.00
            //};
            //guest1.Hotel = hotel1;

            //Guest guest2 = new Guest()
            //{
            //    FirstName = "Jacoby",
            //    LastName = "Brown",
            //    PhoneNumber = "6235552021",
            //    Email = "JB1345@hotmail.com",
            //    BillPaid = false,
            //    NightsStaying = 2,
            //    AmountDue = 0.00
            //};
            //guest2.Hotel = hotel2;

            //Guest guest3 = new Guest()
            //{
            //    FirstName = "Jane",
            //    LastName = "Henderson",
            //    PhoneNumber = "4805552120",
            //    Email = "JanesGotAGun@hotmail.com",
            //    BillPaid = false,
            //    NightsStaying = 5,
            //    AmountDue = 0.00
            //};
            //guest3.Hotel = hotel3;

            //Guest guest4 = new Guest()
            //{
            //    FirstName = "Marissa",
            //    LastName = "Rameria",
            //    PhoneNumber = "7685551202",
            //    Email = "Marmameria@hotmail.com",
            //    BillPaid = false,
            //    NightsStaying = 10,
            //    AmountDue = 0.00
            //};
            //guest4.Hotel = hotel4;

            //Guest guest5 = new Guest()
            //{
            //    FirstName = "Alexis",
            //    LastName = "Katempsi",
            //    PhoneNumber = "9585554856",
            //    Email = "Kamtexis13@hotmail.com",
            //    BillPaid = false,
            //    NightsStaying = 5,
            //    AmountDue = 0.00
            //};
            //guest5.Hotel = hotel5;

            //Reservation res1 = new Reservation()
            //{
            //    AmountDue = Convert.ToDouble(String.Format("{0:C}", (room1.RoomRate * guest1.NightsStaying).ToString()))
            //};
            //res1.Hotel = hotel1;
            //res1.Guest = guest1;
            //res1.Room = room1;
            //context.Reservations.Add(res1);
            //guest1.AmountDue += res1.AmountDue;
            //context.Guests.Add(guest1);

            //Reservation res2 = new Reservation()
            //{
            //    AmountDue = Convert.ToDouble(String.Format("{0:C}", (room2.RoomRate * guest2.NightsStaying).ToString()))
            //};
            //res2.Hotel = hotel2;
            //res2.Guest = guest2;
            //res2.Room = room2;
            //guest2.AmountDue += res2.AmountDue;
            //context.Guests.Add(guest2);
            //context.Reservations.Add(res2);

            //Reservation res3 = new Reservation()
            //{
            //    AmountDue = Convert.ToDouble(String.Format("{0:C}", (room3.RoomRate * guest3.NightsStaying).ToString()))
            //};
            //res3.Hotel = hotel3;
            //res3.Guest = guest3;
            //res3.Room = room3;
            //guest3.AmountDue += res3.AmountDue;
            //context.Guests.Add(guest2);
            //context.Reservations.Add(res3);

            //Reservation res4 = new Reservation()
            //{
            //    AmountDue = Convert.ToDouble(String.Format("{0:C}", (room4.RoomRate * guest4.NightsStaying).ToString()))
            //};
            //res4.Hotel = hotel4;
            //res4.Guest = guest4;
            //res4.Room = room4;
            //guest4.AmountDue += res4.AmountDue;
            //context.Guests.Add(guest4);
            //context.Reservations.Add(res4);

            //Reservation res5 = new Reservation()
            //{
            //    AmountDue = Convert.ToDouble(String.Format("{0:C}", (room6.RoomRate * guest5.NightsStaying).ToString()))

            //};
            //res5.Hotel = hotel5;
            //res5.Guest = guest5;
            //res5.Room = room6;
            //guest5.AmountDue += res5.AmountDue;
            //context.Guests.Add(guest5);
            //context.Reservations.Add(res5);
            //context.SaveChanges();
        }
    }
}
