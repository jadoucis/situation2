using Car_Rental.Manager;
using Car_Rental.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Car_Rental
{
    public partial class FormCar : Form
    {
        private Car car;
        CarManager CarManager;

        public FormCar()
        {
            InitializeComponent();
            CarManager = new CarManager();
        }

        // Classe permettant de rafraichir la listview à chaque requête

        private void Refresh()
        {
            lvCarList.Columns.Clear();
            // Ajout des colonnes
            lvCarList.Columns.Add(new ColumnHeader() { Name = "boat_id", Text = "Id", Width = 30 });
            lvCarList.Columns.Add(new ColumnHeader() { Name = "boat_name", Text = "Nom", Width = 120 });
            lvCarList.Columns.Add(new ColumnHeader() { Name = "boat_license", Text = "License", Width = 100 });
            lvCarList.Columns.Add(new ColumnHeader() { Name = "boat_slot", Text = "Nb Portes", Width = 40 });
            lvCarList.Columns.Add(new ColumnHeader() { Name = "boat_description", Text = "Description", Width = 190 });
            lvCarList.Columns.Add(new ColumnHeader() { Name = "boat_price", Text = "Prix HT", Width = 100 });
            lvCarList.Columns.Add(new ColumnHeader() { Name = "boat_isRented", Text = "Loue", Width = 90 });
            lvCarList.Columns.Add(new ColumnHeader() { Name = "boat_needRepair", Text = "Besoin de réparation?", Width = 90 });
            lvCarList.Columns.Add(new ColumnHeader() { Name = "boat_type", Text = "Type", Width = 160 });
            lvCarList.Columns.Add(new ColumnHeader() { Name = "boat_nbRented", Text = "Nb location", Width = 160 });

            lvCarList.Items.Clear();

            foreach (Car car in CarManager.ListCar())
            {
                // Création de l'élément à ajouter au ListView
                ListViewItem lvi = new ListViewItem(new string[] {
                    car.IdCar.ToString(),
                    car.NameCar.ToString(),
                    car.LicenseCar.ToString(),
                    car.SlotCar.ToString(),
                    car.DescriptionCar.ToString(),
                    car.PriceCar.ToString(),
                    car.IsRentedCar ? "Non disponible" : "Disponible",
                    car.NeedReparedCar ? "Oui" : "Non",
                    car.IdCarModelNavigation.NameCarModel});
                    
                lvi.Tag = car;
                lvCarList.Items.Add(lvi);
            }
            // Faut rajouter toutes les box avec le ".text" et dire ' xxxxx.text = ""; '
            // Partout dans chaque refresh pour que les textbox puissent faire un effet de réinitialisation
        }

            // Chargement de la listview

            private void FormCar_Load(object sender, EventArgs e)
        {
            NameCarModel.DataSource = CarManager.ListCarModel().Select(x => x.NameCarModel).Distinct().ToList();
            var test = CarManager.ListCar();
            idCarModel.DataSource = CarManager.ListCarModel().Select(x => x.IdCarModel).Distinct().ToList();
            Refresh();
        }

        // Sélection d'un voiture dans la combobox dont l'id est égal au nom

        private void NameCarModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NameCarModel.SelectedIndex < 0)
                return;
            if (idCarModel.SelectedIndex < 0)
                return;
            idCarModel.SelectedIndex = NameCarModel.SelectedIndex;
        }

        // Sélection d'un id de voiture dans la combobox dont le nom est égal à l'id

        private void idCarModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (idCarModel.SelectedIndex < 0)
                return;
            NameCarModel.SelectedIndex = idCarModel.SelectedIndex;
        }

        // Evènement double clique permettant de remplir toutes les cases

        private void lvCarList_DoubleClick(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = lvCarList.SelectedItems;
            if (selected.Count == 1)
            {
                car = selected[0].Tag as Car;

                NameCar.Text = car.NameCar;
                LicenseCar.Text = car.LicenseCar;
                SlotCar.Text = car.SlotCar.ToString();
                DescriptionCar.Text = car.DescriptionCar.ToString();
                PriceCar.Text = car.PriceCar.ToString();
                idCarModel.Text = car.IdCarModel.ToString();
                NameCarModel.Text = car.IdCarModelNavigation.NameCarModel.ToString();
                RentedCar.Checked = car.IsRentedCar;
                needRepared.Checked = car.NeedReparedCar;
            }
        }

        // Ajout  d'un voiture 

        private void AddCar_Click(object sender, EventArgs e)
        {
            Car verify = CarManager.FindACarByLicense(LicenseCar.Text);
            if (verify != null)
            {
                MessageBox.Show("Erreur lors de l'ajout de la voiture car la plaque d'immatriculation est déjà renseignée");
            }
            // ajout de Regex tels que "nameboat" = Lettres seulement et SlotBoat = chiffre uniquement
            else if (NameCar.Text == null || LicenseCar.Text is null || DescriptionCar.Text is null || PriceCar is null)
            {
                MessageBox.Show("Erreur lors de l'ajout du voiture, vérifiez les champs.");
            }
            else
            {
                Car car = new Car(NameCar.Text.ToString(), LicenseCar.Text, Convert.ToInt32(SlotCar.Text), DescriptionCar.Text.ToString(), Convert.ToDouble(PriceCar.Text), RentedCar.Checked, needRepared.Checked, Convert.ToInt32(idCarModel.SelectedValue));
                CarManager.AddACar(car);
                MessageBox.Show("Voiture ajouté");
                Refresh();
            }
        }

        // Suppression d'un voiture

        private void DeleteCar_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = lvCarList.SelectedItems;
            if (car.IsRentedCar == false)
            {
                if (selected.Count == 1)
                {
                    car = selected[0].Tag as Car;
                    CarManager.DeleteACar(car);
                    MessageBox.Show("Voiture supprimée");
                    Refresh();
                }
            }
            else
            {
                MessageBox.Show("Impossible de supprimer la voiture");
            }
        }

        // Modification d'un voiture

        private void UpdateCar_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = lvCarList.SelectedItems;
            if (selected.Count == 1)
            {
                if (car.NameCar != NameCar.Text)
                {
                    MessageBox.Show("Vous ne pouvez pas changer le nom du voiture");
                }
                else if (car.SlotCar.ToString() != SlotCar.Text)
                {
                    MessageBox.Show("Les places sur la voiture ne peuvent pas être différentes.");
                }
                else if (car.IdCarModelNavigation.IdCarModel != Convert.ToInt32(idCarModel.Text))
                {
                    MessageBox.Show("Vous ne pouvez pas changer la marque de la voiture");
                }
                else
                {
                    car.LicenseCar = LicenseCar.Text;
                    car.DescriptionCar= DescriptionCar.Text;
                    car.PriceCar = Convert.ToDouble(PriceCar.Text);
                    car.IsRentedCar = RentedCar.Checked;
                    car.NeedReparedCar = needRepared.Checked;
                    CarManager.EditACar(car);
                    MessageBox.Show("Voiture modifiée !");
                }
                Refresh();
            }
        }

        // Bouton rafraichir les textbox

        private void RefreshText_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        //  Bouton Quitter

        private void Leave_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lvCarList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
