using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Car_Rental
{
    public partial class FormRentalManager : Form
    {

        // Comme dans "FormMenu" je déclare différents booléens pour les différentes pages que je vais créer

        bool modelCar = false;
        bool car = false;
        bool customer = false;
        bool command = false;

        public FormRentalManager()
        {
            InitializeComponent();
        }

        private void button_AddCarModel_Click(object sender, EventArgs e)
        {
            modelCar = true;
            FormCarModel FormCarModel = new FormCarModel();
            FormCarModel.ShowDialog();
        }

        private void button_CarStock_Click(object sender, EventArgs e)
        {
            car = true;
            FormCar FormCar = new FormCar();
            FormCar.ShowDialog();
        }

        // Ce bouton ouvrira la page de gestion des clients

        private void button_AddConsumer_Click(object sender, EventArgs e)
        {
            customer = true;
            FormCustomer FormCustomer = new FormCustomer();
            FormCustomer.ShowDialog();
        }

        // Ce bouton ouvrira la page de gestion des commandes de voitures

        private void button_AddCommand_Click(object sender, EventArgs e)
        {
            command = true;
            FormCommand Command = new FormCommand();
            Command.ShowDialog();
        }

        private void button_quit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
