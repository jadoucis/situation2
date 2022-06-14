
namespace Car_Rental
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.list_member = new System.Windows.Forms.ListView();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(570, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(390, 40);
            this.label5.TabIndex = 80;
            this.label5.Text = "Gestion des administrateurs";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOrange;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(560, 671);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(339, 75);
            this.button2.TabIndex = 79;
            this.button2.Text = "Quitter";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // list_member
            // 
            this.list_member.FullRowSelect = true;
            this.list_member.GridLines = true;
            this.list_member.HideSelection = false;
            this.list_member.Location = new System.Drawing.Point(46, 176);
            this.list_member.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.list_member.Name = "list_member";
            this.list_member.Size = new System.Drawing.Size(542, 457);
            this.list_member.TabIndex = 78;
            this.list_member.UseCompatibleStateImageBehavior = false;
            this.list_member.View = System.Windows.Forms.View.Details;
            this.list_member.DoubleClick += new System.EventHandler(this.list_member_DoubleClick);
            // 
            // button_Reset
            // 
            this.button_Reset.BackColor = System.Drawing.Color.DarkOrange;
            this.button_Reset.Location = new System.Drawing.Point(1085, 528);
            this.button_Reset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(225, 75);
            this.button_Reset.TabIndex = 77;
            this.button_Reset.Text = "Rafraîchir la page";
            this.button_Reset.UseVisualStyleBackColor = false;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.DarkOrange;
            this.button_Delete.Location = new System.Drawing.Point(815, 528);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(225, 75);
            this.button_Delete.TabIndex = 76;
            this.button_Delete.Text = "Supprimer un administrateur";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.Color.DarkOrange;
            this.button_Update.Location = new System.Drawing.Point(1085, 424);
            this.button_Update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(225, 75);
            this.button_Update.TabIndex = 75;
            this.button_Update.Text = "Modifier un administrateur";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Wheat;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(854, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 35);
            this.label3.TabIndex = 74;
            this.label3.Text = "Mot de passe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(155, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 40);
            this.label1.TabIndex = 73;
            this.label1.Text = "Liste des administrateurs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(889, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 35);
            this.label2.TabIndex = 72;
            this.label2.Text = "Login";
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.DarkOrange;
            this.button_Add.Location = new System.Drawing.Point(815, 424);
            this.button_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(225, 75);
            this.button_Add.TabIndex = 71;
            this.button_Add.Text = "Ajouter un administrateur";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(1085, 324);
            this.password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.PlaceholderText = "Mot de passe";
            this.password.Size = new System.Drawing.Size(175, 29);
            this.password.TabIndex = 70;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(1085, 235);
            this.login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.login.Multiline = true;
            this.login.Name = "login";
            this.login.PlaceholderText = "Login";
            this.login.Size = new System.Drawing.Size(175, 29);
            this.login.TabIndex = 69;
            this.login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(904, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(375, 40);
            this.label4.TabIndex = 68;
            this.label4.Text = "Création d\'administrateurs";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1402, 761);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.list_member);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label4);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAdmin";
            this.Text = "Gestionnaire des administrateurs";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView list_member;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label label4;
    }
}