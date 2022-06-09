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
    public partial class FormCarModel : Form
    {
        CarModel carmodel;
        CarModelManager CarModelManager;

        public FormCarModel()
        {
            InitializeComponent();
            // T'es obligé de le déclarer ici sinon ça retourne une erreur expliquant que l'objet demandé a une valeur null
            CarModelManager = new CarModelManager();
        }

        // Même chose que sur toutes les autres pages, je configure la Listview lvCarModel pour l'adapter à ce que je veux

        private void Refresh()
        {
            lvCarModel.Columns.Clear();
            // Ajout des colonnes
            lvCarModel.Columns.Add(new ColumnHeader() { Name = "CarModel_id", Text = "Id", Width = 100 });
            lvCarModel.Columns.Add(new ColumnHeader() { Name = "CarModel_name", Text = "Nom de la marque", Width = 120 });

            lvCarModel.Items.Clear();

            foreach (CarModel CarModel in CarModelManager.ListCarModel())
            {
                // Création de l'élément à ajouter au ListView
                ListViewItem lvi = new ListViewItem(new string[] {
                    CarModel.IdCarModel.ToString(),
                    CarModel.NameCarModel.ToString()});
                lvi.Tag = CarModel;
                lvCarModel.Items.Add(lvi);
            }
            NameCarModel.Text = "";
        }

        // Au chargement de la page, la listeview lvCarModel se charge automatiquement en utilisant la commande "Refresh()"

        private void FormCarModel_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        // Evènement qui remplit la textbox lorsque tu double clique sur un élément de la liste
        private void lvCarModel_DoubleClick(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = lvCarModel.SelectedItems;
            if (selected.Count == 1)
            {
                carmodel = selected[0].Tag as CarModel;

                NameCarModel.Text = carmodel.NameCarModel;
            }
        }

        // Bouton ajouter une marque de voiture

        private void button_Add_Click(object sender, EventArgs e)
        {
            CarModel verify = CarModelManager.FindCarModelByName(NameCarModel.Text);

            if (verify == null)
            {
                CarModel CarModel = new CarModel(NameCarModel.Text);
                CarModelManager.AddACarModel(CarModel);
                MessageBox.Show("Marque de voiture ajoutée");
                Refresh();
            }
            else
            {
                MessageBox.Show("Erreur lors de l'ajout, cette marque de voiture existe déjà");
            }
        }

        // Bouton permettant la mise à jour d'une marque de voiture

        private void button_Update_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = lvCarModel.SelectedItems;
            if (selected.Count == 1)
            {
                carmodel.NameCarModel= NameCarModel.Text;
                CarModelManager.EditACarModel(carmodel);
                MessageBox.Show("Marque de voiture modifiée !");
            }
            Refresh();
        }

        // Comme je te l'ai déjà expliqué à l'oral / à l'écrit
        // Je ne préfère pas mettre la possibilité de supprimer un modèle de voiture car
        // C'est trop la merde, c'est une FK donc si elle est utilisée par des voitures faut delete les voitures
        // Mais tu peux pas delete une voiture si elle est en location, donc t'es condamné à ne pas supprimer la marque mdr


        // Bouton permettant de quitter cette page

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
