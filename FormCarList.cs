using Car_Rental.Manager;
using Car_Rental.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Car_Rental
{
    public partial class FormCarList : Form
    {
        CarManager CarManager;
        public FormCarList()
        {
            InitializeComponent();
            CarManager = new CarManager();
        }

        private void Refresh(List<Car> list)
        {
            lvListBikes.Columns.Clear();
            // Ajout des colonnes
            lvListBikes.Columns.Add(new ColumnHeader() { Name = "car_Id", Text = "Identifiant", Width = 100 });
            lvListBikes.Columns.Add(new ColumnHeader() { Name = "car_Nom", Text = "Nom", Width = 150 });
            lvListBikes.Columns.Add(new ColumnHeader() { Name = "car_Plaque", Text = "Plaque", Width = 150 });
            lvListBikes.Columns.Add(new ColumnHeader() { Name = "car_Place", Text = "Nombre de portes", Width = 150 });
            lvListBikes.Columns.Add(new ColumnHeader() { Name = "car_Description", Text = "Description", Width = 150 });
            lvListBikes.Columns.Add(new ColumnHeader() { Name = "car_Loue", Text = "Loue", Width = 300 });
            lvListBikes.Columns.Add(new ColumnHeader() { Name = "car_Modele", Text = "Marque", Width = 200 });


            lvListBikes.Items.Clear();

            foreach (Car car in list)
            {
                ListViewItem lvi = new ListViewItem(new string[]
                    {
                        car.IdCar.ToString(),
                        car.NameCar.ToString(),
                        car.LicenseCar.ToString(),
                        car.SlotCar.ToString(),
                        car.DescriptionCar.ToString(),
                        car.IsRentedCar ? "Location en cours" : "Disponible",
                        car.IdCarModelNavigation.NameCarModel.ToString()
                    });
                lvi.Tag = car;
                lvListBikes.Items.Add(lvi);
            }
        }

        // Initialisation de la listview
        private void FormCarList_Load(object sender, EventArgs e)
        {
            Refresh(CarManager.ListCar());
        }

        // Bouton permettant la recherche d'une moto par sa plaque d'immatriculation

        private void searchButton_Car_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchBar_Car.Text))
            {
                // Liste retournant toutes les motos sans aucune distinction

                Refresh(CarManager.ListCar());
                return;
            }

            // Utilisation de la nouvelle liste retournant seulement les plaques commençant par ce que t'as mis dans la textbox

            Refresh(CarManager.FindCarStartByLicense(searchBar_Car.Text));
        }

        // Bouton permettant de quitter la page actuelle

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
