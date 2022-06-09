using Car_Rental.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace Car_Rental.Manager
{
    public class CarManager : DataManager
    {

        // Requête SQL permettant d'ajouter une car 

        public Car AddACar(Car car)
        {
            Context.Cars.Add(car);
            if (Context.SaveChanges() > 0)
                return car;
            return null;
        }


        // Requête SQL permettant de supprimer une car 

        public bool DeleteACar(Car car)
        {
            if (car != null)
            {
                Context.Cars.Remove(car);
                return (Context.SaveChanges() > 0);
            }
            return false;
        }


        // Requête SQL permettant de faciliter la recherche de la véhicule pour supprimer une car 

        public bool DeleteACar(int id)
        {
            Car car = FindACarByID(id);
            if (car == null)
                return false;
            return DeleteACar(car);
        }


        // Requête SQL permettant de modifier une véhicule 

        public bool EditACar(Car car)
        {
            Context.Entry(car).State = EntityState.Modified;
            return (Context.SaveChanges() > 0);
        }


        // Requête SQL permettant de rechercher une car par son identifiant

        public Car FindACarByID(int id)
        {
            return Context.Cars.Find(id);
        }

        /* 
          Trouver les cars qui sont en location
        
          public Boat FindACarByRent(bool rent)
          {
              Context.Cars.Where(car => car.IsRentedCar.checked);
          }

        Top 3 des véhicules les plus cheres

             public List<Car> top3HighestPrice()
        {
            var list = Context.Bikes.AsQueryable();
            list = list.OrderByDescending(bike => bike.PriceBike).Take(3);
            return list.ToList();
        }
        */

        // Requête SQL permettant de trouver une véhicule par sa plaque d'immatriculation 

        public Car FindACarByLicense(string license)
            => Context.Cars.FirstOrDefault(car => car.LicenseCar == license);


        // Requête SQL permettant de trouver une car dont le nom de la plaque d'immat commence par

        public List<Car> FindCarStartByLicense(string license)
            => Context.Cars.Where(car => car.LicenseCar.StartsWith(license)).ToList();


        // Requête SQL permettant de créer une liste de toutes les cars

        public List<Car> ListCar()
            => Context.Cars.ToList();

        public List<CarModel> ListCarModel()
            => Context.Carmodels.ToList();

        // Requête SQL permettant de récupérer les top 5 des cars les plus chères

        public List<Car> top5(string car)
        {
            var list = Context.Cars.AsQueryable();
            list = list.OrderByDescending(car => car.NameCar).Where(c => c.IsRentedCar == true).Take(5);
            return list.ToList();
        }
    }
}
