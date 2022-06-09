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
    public partial class FormAdmin : Form
    {
        MemberManager MemberManager;
        private Member member;

        public FormAdmin()
        {
            InitializeComponent();
            MemberManager = new MemberManager();
        }

        // Fonction permettant de rafraichir la listview à chaque requête

        private void Refresh()
        {
            // Je clear toutes les colonnes qui sont existantes

            list_member.Columns.Clear();

            // Déclaration de chaque colonne que je vais utiliser. Je ne suis pas obligé de respecter ma bdd. Si je ne veux pas afficher la colonne "ID" je ne la mets pas

            list_member.Columns.Add(new ColumnHeader() { Name = "ID", Text = "ID", Width = 150 });
            list_member.Columns.Add(new ColumnHeader() { Name = "Login", Text = "Login", Width = 150 });
            list_member.Columns.Add(new ColumnHeader() { Name = "Mot de passe", Text = "Mot de passe", Width = 150 });

            // Une fois que les colonnes sont initialisés, je reset tous les éléments pour être sûr qu'elle soit bien vide

            list_member.Items.Clear();

            // Déclaration d'un foreach de la liste "ListMember" déclarée dans "MemberManager.cs", l'idée est de GET tous les membres
            foreach (Member member in MemberManager.ListMember())
            {
                ListViewItem lvi = new ListViewItem(new string[]
                    {
                        // Chaque ligne indiqué est en fonction de la colonne. Si je commence par "Login" alors que dans "Columns.add" je déclare l'id, il n'y aura pas d'erreur
                        // Mais j'aurai affiché un login dans la colonne "ID" :)

                        member.IdMember.ToString(),
                        member.LoginMember.ToString(),
                        member.PasswordMember.ToString()
                    });

                // Aucune idée à quoi ça sert mais c'est obligatoire je crois

                lvi.Tag = member;

                // Pareil, j'en sais rien dsl

                list_member.Items.Add(lvi);
            }

            // Je réinitialise toutes mes textbox avec des chaines vides pour faire un effet de "reinitialisation"

            login.Text = "";
            password.Text = "";
        }

        // Au démarrage de la page, j'appelle la fonction Refresh pour qu'elle génère le tableau (la listview déclarée dans la fonction)

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            Refresh();
        }


        // Récupération du login et du mdp de l'utilisateur double cliqué sur la listview

        private void list_member_DoubleClick(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = list_member.SelectedItems;
            if (selected.Count == 1)
            {
                member = selected[0].Tag as Member;

                // A la sélection d'un membre, le login.text prendra la valeur du tableau, pareil pour le mdp
                login.Text = member.LoginMember;
                password.Text = member.PasswordMember;
            }
        }

        // FONCTION POUR AJOUTER UN MEMBER AU CLIQUE DU BOUTON FAIT PAR L'UTILISATEUR DE L'APPLICATION 

        private void button_Add_Click(object sender, EventArgs e)
        {
            // J'appelle la fonction "FindAMemberByLogin" qui se trouve dans le manager "MemberManager.cs"
            // Je déclare le "login.text" comme chaine de caractères
            // Le nom de la box est "login" mais comme j'ai besoin d'une chaine, je mets .text ou .toString()

            Member verify = MemberManager.FindAMemberByLogin(login.Text);

            // Je vérifie dans un premier temps si les champs login et mot de passe sont vides, si c'est le cas erreur

            if (string.IsNullOrEmpty(login.Text) || string.IsNullOrEmpty(password.Text))
            {
                MessageBox.Show("Impossible d'ajouter un administrateur car vous n'avez pas remplis tous les champs");
            }

            // Si "verify" n'est pas null cela signifie qu'un admin est déjà existant dans la bdd avec ce login donc erreur

            else if (verify != null)
            {
                MessageBox.Show("Vous ne pouvez pas créer deux administrateurs avec le même login.");
            }
            else
            {
                // Pour ajouter un member il faut respecter les différents constructeurs (dans Models) et appliquer la même syntaxe.
                // Pour un member, il faut un login et un password. Encore une fois, il faut des chaînes de caractères.

                Member member = new Member(login.Text, password.Text);

                // J'appelle ma fonction AddAMember qui ajoute un membre dans la bdd, "member" qui est celui déclaré la ligne juste au dessus

                MemberManager.AddAMember(member);

                // J'envoie le msg indiquant que l'action s'est bien déroulée

                MessageBox.Show("Administrateur ajouté !");

                // J'appelle la fonction refresh pour rafraichir le tableau avec la nouvelle valeur

                Refresh();
            }
        }

        // FONCTION POUR SUPPRIMER UN MEMBER AU CLIQUE DU BOUTON FAIT PAR L'UTILISATEUR DE L'APPLICATION 

        private void button_Delete_Click(object sender, EventArgs e)
        {
            // C'est pour sélectionner un membre, mais en vrai je sais pas à quoi ça sert, aucune explication

            ListView.SelectedListViewItemCollection selected = list_member.SelectedItems;

            // aucune explication, c'est juste là pour que tout fonctionne

            if (selected.Count == 1)
            {

                // Pareil...

                member = selected[0].Tag as Member;

                // J'appelle la fonction supprimer de "MemberManager.cs"

                MemberManager.DeleteAMember(member);
                MessageBox.Show("Administrateur supprimé");
                Refresh();
            }
            // Si selected.count n'est pas égale à 1, erreur automatiquement

            else
            {
                MessageBox.Show("Impossible de supprimer l'administrateur");
                Refresh();
            }
        }

        // FONCTION POUR MODIFIER UN MEMBER AU CLIQUE DU BOUTON FAIT PAR L'UTILISATEUR DE L'APPLICATION 

        private void button_Update_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = list_member.SelectedItems;
            if (selected.Count == 1)
            {
                // Lorsque je modifie, si l'utilisateur a modifié le login du mec je mets une erreur, on peut faire sauter cette protection, en soit elle sert pas de fou

                if (login.Text != member.LoginMember)
                {
                    MessageBox.Show("Vous ne pouvez pas changer le login de l'administrateur.");
                }

                // Sinon, je donne la nouvelle valeur du mot de passe
                else
                {
                    member.PasswordMember = password.Text;
                    MemberManager.EditAMember(member);
                    MessageBox.Show("Administrateur modifié.");
                }
                Refresh();
            }
        }

        // FONCTION POUR REINITIALISER LES TEXTBOX AU CLIQUE DU BOUTON FAIT PAR L'UTILISATEUR DE L'APPLICATION 

        private void button_Reset_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        // FONCTION POUR QUITTER LA PAGE

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
