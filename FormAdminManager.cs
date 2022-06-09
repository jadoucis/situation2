using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Car_Rental
{
    public partial class FormAdminManager : Form
    {

        // Déclaration des différents booléens comme dans "FormRentalManager" et "FormMenu"

        bool Admin = false;
        bool CarList = false;
        bool CustomerList = false;
        bool CommandList = false;

        public FormAdminManager()
        {
            InitializeComponent();
        }

        // Ce bouton ouvrira la page de gestion des admins

        private void button_AdminAccount_Click(object sender, EventArgs e)
        {
            Admin = true;
            FormAdmin FormAdmin = new FormAdmin();
            FormAdmin.ShowDialog();
        }

        // Ce bouton ouvrira la page de liste des cars
        private void carLists_Click(object sender, EventArgs e)
        {
            CarList = true;
            FormCarList FormCarList = new FormCarList();
            FormCarList.ShowDialog();
        }

        // Ce bouton ouvrira la page de liste des clients

        private void button_CustomerList_Click(object sender, EventArgs e)
        {
            CustomerList = true;
            FormCustomerList FormCustomerList = new FormCustomerList();
            FormCustomerList.ShowDialog();
        }

        // Ce bouton ouvrira la page de liste des commandes

        private void button_CommandList_Click(object sender, EventArgs e)
        {
            CommandList = true;
            FormCommandList FormCommandList = new FormCommandList();
            FormCommandList.ShowDialog();
        }

        private void button_quit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
