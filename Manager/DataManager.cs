using Car_Rental.Models;
using Microsoft.EntityFrameworkCore;

namespace Car_Rental.Manager
{
    public abstract class DataManager
    {
        public readonly car_rentalContext Context;

        public DataManager()
        {
            var test = new DbContextOptionsBuilder<car_rentalContext>().UseLazyLoadingProxies();
            Context = new car_rentalContext(test.Options);
        }
    }
}
