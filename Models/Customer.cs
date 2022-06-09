using System;
using System.Collections.Generic;

#nullable disable

namespace Car_Rental.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Commands = new HashSet<Command>();
        }

        public int IdCustomer { get; set; }
        public string FirstNameCustomer { get; set; }
        public string LastNameCustomer { get; set; }
        public DateTime AgeCustomer { get; set; }
        public string MailCustomer { get; set; }
        public bool CarLicenseCustomer { get; set; }
        public bool HasRentedCustomer { get; set; }

        public virtual ICollection<Command> Commands { get; set; }

        public Customer(string firstNameCustomer, string lastNameCustomer, DateTime ageCustomer, string mailCustomer, bool carLicenseCustomer, bool hasRentedCustomer)
        {
            FirstNameCustomer = firstNameCustomer;
            LastNameCustomer = lastNameCustomer;
            AgeCustomer = ageCustomer;
            MailCustomer = mailCustomer;
            CarLicenseCustomer = carLicenseCustomer;
            HasRentedCustomer = hasRentedCustomer;
        }
    }
}
