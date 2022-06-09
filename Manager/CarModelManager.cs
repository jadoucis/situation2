using Car_Rental.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car_Rental.Manager
{
    public class CarModelManager : DataManager
    {

        // Requête SQL permettant d'ajouter un modèle de car 

        public CarModel AddACarModel(CarModel carmodel)
        {
            if(carmodel != null)
            {
                Context.Carmodels.Add(carmodel);
                if (Context.SaveChanges() > 0)
                    return carmodel;
            }
            return null;
        }


        // Requête SQL permettant de supprimer un modèle de car (tu t'en serviras jamais normalement)

        public bool DeleteACarModel(CarModel carmodel)
        {
            if (carmodel != null)
            {
                Context.Carmodels.Remove(carmodel);
                return (Context.SaveChanges() > 0);
            }
            return false;
        }


        // Requête SQL permettant de recherche un modèle de car par son id puis de le supprimer

        public bool DeleteACarModel(int id)
        {
            CarModel carmodel = FindACarModelByID(id);
            if (carmodel == null)
                return false;
            return DeleteACarModel(carmodel);
        }

        // Requête SQL permettant de rechercher un modèle de car 

        public bool EditACarModel(CarModel carmodel)
        {
            Context.Entry(carmodel).State = EntityState.Modified;
            return (Context.SaveChanges() > 0);
        }


        // Requête SQL permettant de rechercher un modèle de car par son identifnat

        public CarModel FindACarModelByID(int id)
        {
            return Context.Carmodels.Find(id);
        }


        // Requête SQL permettant de rechercher un modèle de moto par son nom

        public CarModel FindCarModelByName(string name)
            => Context.Carmodels.FirstOrDefault(carmodel => carmodel.NameCarModel == name);


        // Requête SQL permettant de créer une liste de tous les modèles de moto 

        public List<CarModel> ListCarModel()
           => Context.Carmodels.ToList();
    }
}
