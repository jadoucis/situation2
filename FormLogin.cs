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
    public partial class FormLogin : Form
    {
        Member member;
        MemberManager MemberManager;
        public bool SuperAdmin = false;
        public FormLogin()
        {
            InitializeComponent();
            MemberManager = new MemberManager();

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
        }

        // "connexionButton" c'est le bouton, "_click" est l'évènement causant cette action

        private void connexionButton_Click(object sender, EventArgs e)
        {
            // Je recherche un membre ayant pour nom d'utilisateur la box "username.text"

            member = MemberManager.FindAMemberByLogin(username.Text);

            // Si le membre est "null" ou que le mot de passe de son compte est  différent de celui indiqué dans la box, alors erreur

            if (member is null || member.PasswordMember != password.Text)
            {
                MessageBox.Show("Identifiant incorrect ou mot de passe incorrect");
                return;
            }
            else
            {
                // Sinon le booléen passe à true, et j'effectue le changement de page dans "Program.cs"

                SuperAdmin = true;
                Close();
            }
        }

        // Close(); permet de fermer la page actuel. "closeButton" c'est le bouton, "_click" est l'évènement causant cette action

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
