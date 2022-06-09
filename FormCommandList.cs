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
    public partial class FormCommandList : Form
    {
        CommandManager CommandManager;

        public FormCommandList()
        {
            InitializeComponent();
            CommandManager = new CommandManager();
        }

    private void Refresh(List<Command> list)
    {
        lvListCommands.Columns.Clear();
        // Ajout des colonnes
        lvListCommands.Columns.Add(new ColumnHeader() { Name = "command_id", Text = "Identifiant Commande", Width = 200 });
        lvListCommands.Columns.Add(new ColumnHeader() { Name = "command_DateEnd", Text = "Date et heure de début", Width = 150 });
        lvListCommands.Columns.Add(new ColumnHeader() { Name = "command_DateEnd", Text = "Date et heure de fin", Width = 150 });
        lvListCommands.Columns.Add(new ColumnHeader() { Name = "command_HasPaiedDeposit", Text = "Caution", Width = 200 });
        lvListCommands.Columns.Add(new ColumnHeader() { Name = "command_MontantTotal", Text = "Montant Total", Width = 150 });
        lvListCommands.Columns.Add(new ColumnHeader() { Name = "command_Name_Customer", Text = "Nom du client", Width = 150 });
        lvListCommands.Columns.Add(new ColumnHeader() { Name = "command_Name_Car", Text = "Nom de la voiture", Width = 150 });

        lvListCommands.Items.Clear();

        foreach (Command command in list)
        {
            // Création de l'élément à ajouter au ListView
            ListViewItem lvi = new ListViewItem(new string[] {
                    command.IdCommand.ToString(),
                    command.DateStartCommand.ToString(),
                    command.DateEndCommand.ToString(),
                    command.HasPaiedDepositCommand ? "Caution payé" : "Caution non payé",
                    command.IdCarNavigation.PriceCar*1.2 + "€",
                    command.IdCustomerNavigation.FirstNameCustomer + " " + command.IdCustomerNavigation.LastNameCustomer,
                    command.IdCarNavigation.NameCar.ToString() });
            lvi.Tag = command;
            lvListCommands.Items.Add(lvi);
        }
    }

    private void FormCommandList_Load(object sender, EventArgs e)
    {
        Refresh(CommandManager.ListCommands());
    }

    private void searchButton_Command_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(searchBar_command.Text))
        {
            Refresh(CommandManager.ListCommands());
            return;
        }
        // Utilisation de la nouvelle liste
        Refresh(CommandManager.FindACommandByCustomerName(searchBar_command.Text));
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Close();
    }
}
}
