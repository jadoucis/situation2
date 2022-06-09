using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Car_Rental
{
    public partial class FormMenu : Form
    {

        // Déclaration de deux booléens permettant d'identifier lorsque l'un passe à true, alors on lance la page

        public bool Rental = false;
        public bool Admin = false;

        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
        }

        private void button_Rental_Click(object sender, EventArgs e)
        {
            // Booléen devient true

            Rental = true;

            // Déclaration de la nouvelle page "form"

            FormRentalManager formRental = new FormRentalManager();

            // Ouverture de la nouvelle page

            formRental.ShowDialog();
        }

        private void button_Admin_Click(object sender, EventArgs e)
        {
            // Booléen devient true

            Admin = true;

            // Déclaration de la nouvelle page "form"

            FormAdminManager formAdmin = new FormAdminManager();

            // Ouverture de la nouvelle page

            formAdmin.ShowDialog();
        }
    }
}
