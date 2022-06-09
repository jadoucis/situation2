using System;
using System.Collections.Generic;

#nullable disable

namespace Car_Rental.Models
{
    public partial class Command
    {
        public int IdCommand { get; set; }
        public DateTime DateStartCommand { get; set; }
        public DateTime DateEndCommand { get; set; }
        public bool HasPaiedDepositCommand { get; set; }
        public int IdCustomer { get; set; }
        public int IdCar { get; set; }

        public virtual Car IdCarNavigation { get; set; }
        public virtual Customer IdCustomerNavigation { get; set; }

        public Command(DateTime dateStartCommand, DateTime dateEndCommand, bool hasPaiedDepositCommand, int idCustomer, int idCar)
        {
            DateStartCommand = dateStartCommand;
            DateEndCommand = dateEndCommand;
            HasPaiedDepositCommand = hasPaiedDepositCommand;
            IdCustomer = idCustomer;
            IdCar = idCar;
        }
    }
}
