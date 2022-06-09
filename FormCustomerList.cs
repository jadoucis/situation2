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
    public partial class FormCustomerList : Form
    {
        CustomerManager CustomerManager;
        public FormCustomerList()
        {
            InitializeComponent();
            CustomerManager = new CustomerManager();
        }

        private void Refresh(List<Customer> list)
        {
            lvListCustomers.Columns.Clear();
            // Ajout des colonnes
            lvListCustomers.Columns.Add(new ColumnHeader() { Name = "customer_Id", Text = "Identifiant", Width = 100 });
            lvListCustomers.Columns.Add(new ColumnHeader() { Name = "customer_Prenom", Text = "Prenom", Width = 150 });
            lvListCustomers.Columns.Add(new ColumnHeader() { Name = "customer_Nom", Text = "Nom", Width = 150 });
            lvListCustomers.Columns.Add(new ColumnHeader() { Name = "customer_Age", Text = "Age", Width = 150 });
            lvListCustomers.Columns.Add(new ColumnHeader() { Name = "customer_email", Text = "Email", Width = 300 });
            lvListCustomers.Columns.Add(new ColumnHeader() { Name = "customer_license", Text = "Permis de conduire ?", Width = 200 });
            lvListCustomers.Columns.Add(new ColumnHeader() { Name = "customer_isrented", Text = "Location en cours ?", Width = 130 });

            lvListCustomers.Items.Clear();

            foreach (Customer customer in list)
            {
                ListViewItem lvi = new ListViewItem(new string[]
                    {
                        customer.IdCustomer.ToString(),
                        customer.FirstNameCustomer.ToString(),
                        customer.LastNameCustomer.ToString(),
                        customer.AgeCustomer.ToString(),
                        customer.MailCustomer.ToString(),
                        customer.CarLicenseCustomer ? "Oui" : "Non",
                        customer.HasRentedCustomer ? "Oui" : "Non"
                    });
                lvi.Tag = customer;
                lvListCustomers.Items.Add(lvi);
            }
        }
        private void FormCustomerList_Load(object sender, EventArgs e)
        {
            Refresh(CustomerManager.GetCustomers());
        }

        private void searchButton_customers_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchBar_customer.Text))
            {
                // Liste retournant tous les clients sans aucune distinction
                Refresh(CustomerManager.GetCustomers());
                return;
            }

            // Utilisation de la nouvelle liste retournant seulement les noms de famille commençant par ce que t'as mis dans la textbox

            Refresh(CustomerManager.FindCustomersByName(searchBar_customer.Text));
        }

        // Bouton pour quitter la page actuelle
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
