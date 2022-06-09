using System;
using System.Collections.Generic;

#nullable disable

namespace Car_Rental.Models
{
    public partial class CarModel
    {
        public CarModel()
        {
            Cars = new HashSet<Car>();
        }

        public int IdCarModel { get; set; }
        public string NameCarModel { get; set; }

        public virtual ICollection<Car> Cars { get; set; }

        public CarModel(string nameCarModel)
        {
            NameCarModel = nameCarModel;
        }
    }
}
