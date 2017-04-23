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
    //Class for hotel staff. This is one area where I tried heavily using encapsulation, but the linq queries gave me a lot of trouble
    //as well as the DataBaseInitializer
    class Staff
    {
        [Key]
        public int StaffId { get; set; }
        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(12)]
        public string PhoneNumber { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public double PayPerHour { get; set; }
        [Required]
        public double Salary { get; set; }
        [Required]
        public int VacationDays { get; set; }
        [Required]
        public DateTime DateHired { get; set; }
        [Required]
        public bool EmployedCurrently { get; set; }
        [Required]
        public bool ReHirable { get; set; }

        public virtual Hotel Hotel { get; set; }

        //Simple calculatePay method for non-salary employees. 
        public double calculatePay(int hours, double payRate)
        {
            double finalPay = 0;

            if (hours > 40)
            {
                return finalPay = ((hours - 40) * (payRate * 1.5)) + (payRate * 40);            
            }
            else if (hours < 40)
            {
                return finalPay = (payRate * hours);
            }
            return finalPay;
        }
        //Simple calculateSalary method for salaried employees. 
        public double calculateSalary(double salary)
        {
            return salary * 2;
        }

        public override string ToString()
        {
            return ("Staff Id: " + StaffId + "\r\n" +
                        "First Name:" + FirstName + "\r\n" +
                        "Last Name: " + LastName + "\r\n" +
                        "Phone: " + PhoneNumber + "\r\n" +
                        "Position: " + Position + "\r\n" +
                        "Pay Rate Per Hour: " + PayPerHour + "\r\n" +
                        "Salary Per Week: " + Salary + "\r\n" +
                        "Vacation Days: " + VacationDays + "\r\n" +
                        "Date Hired: " + DateHired + "\r\n" +
                        "Currently Employed: " + EmployedCurrently + "\r\n" +
                        "Able to be re-hired: " + ReHirable);
        }
    }
}
