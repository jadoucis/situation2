using Car_Rental.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car_Rental.Manager
{
    public class CommandManager : DataManager
    {

        // Déclaration du client et de la car pour les éditer lors de l'ajout d'une commande

        CustomerManager customerManager = new CustomerManager();
        CarManager carManager = new CarManager();

        public Command AddACommand(Command command)
        {

            // Afin d'éviter l'erreur "set of an instance object null"

            if( command != null && customerManager != null && carManager != null )
            {
                // Je récupère l'id du client ainsi que l'id de la car

                Customer customer = customerManager.FindACustomerByID(command.IdCustomer);
                Car car = carManager.FindACarByID(command.IdCar);
                Context.Commands.Add(command);
                if (Context.SaveChanges() > 0)
                {
                    // Lorsque je valide l'ajout de la commande, je change l'état des booléens de customer et de car

                    customer.HasRentedCustomer = true;
                    car.IsRentedCar = true;
                    customerManager.EditACustomer(customer);
                    carManager.EditACar(car);
                    return command;
                }
            }
            return null;
        }


        // Requête SQL permettant de supprimer une commande

        public bool DeleteACommand(Command command)
        {
            if (command != null)
            {
                Context.Commands.Remove(command);
                return (Context.SaveChanges() > 0);
            }
            return false;
        }


        // Requête SQL permettant de supprimer une commande en la recherchant par son ID

        public bool DeleteACommand(int id)
        {
            Command command = FindACommandByCommandID(id);
            if (command == null)
                return false;
            return DeleteACommand(command);
        }


        // Requête SQL permettant de modifier une commande

        public bool EditACommand(Command command)
        {
            Context.Entry(command).State = EntityState.Modified;
            return (Context.SaveChanges() > 0);
        }


        // Récupération d'une commande par son identifiant

        public Command FindACommandByCommandID(int id)
        {
            return Context.Commands.Find(id);
        }


        // Trouver une commande de client par l'identifiant du client

        public Command FindACommandByIDCustomerAndDate(int id, DateTime debut)
        {
            return Context.Commands.FirstOrDefault(command => command.IdCustomerNavigation.IdCustomer == id && command.DateStartCommand.Equals(debut));
        }


        // Trouver une commande par l'identifiant de la car

        public Command FindACommandByCarID(int idbike)
            => Context.Commands.FirstOrDefault(command => command.IdCar == idbike && command.IdCarNavigation.IsRentedCar);


       // Récupération de toutes les commandes dans une liste

        public List<Command> ListCommands()
        {
            var list = Context.Commands
                .Include(cmd => cmd.IdCarNavigation)
                .Include(cmd => cmd.IdCustomerNavigation)
                .AsQueryable();
            return list.ToList();
        }


        // Récupération d'une commande par le nom du client

        public List<Command> FindACommandByCustomerName(string first)
    => Context.Commands.Where(cmd => cmd.IdCustomerNavigation.LastNameCustomer.StartsWith(first)).ToList();


        // Récupération d'une commande par l'identifiant du client

        public Command FindACommandByCustomerId(int id)
            => Context.Commands.FirstOrDefault(command => command.IdCustomer == id);
    }
}
