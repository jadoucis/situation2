using System;
using System.Collections.Generic;

#nullable disable

namespace Car_Rental.Models
{
    public partial class Car
    {
        public Car()
        {
            Commands = new HashSet<Command>();
        }

        public int IdCar { get; set; }
        public string NameCar { get; set; }
        public string LicenseCar { get; set; }
        public int SlotCar { get; set; }
        public string DescriptionCar { get; set; }
        public double PriceCar { get; set; }
        public bool IsRentedCar { get; set; }
        public int IdCarModel { get; set; }

        public virtual CarModel IdCarModelNavigation { get; set; }
        public virtual ICollection<Command> Commands { get; set; }

        public Car(string nameCar, string licenseCar, int slotCar, string descriptionCar, double priceCar, bool isRentedCar, int idCarModel)
        {
            NameCar = nameCar;
            LicenseCar = licenseCar;
            SlotCar = slotCar;
            DescriptionCar = descriptionCar;
            PriceCar = priceCar;
            IsRentedCar = isRentedCar;
            IdCarModel = idCarModel;
        }
    }
}
