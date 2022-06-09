
namespace Car_Rental
{
    partial class FormLogin
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
            this.bienvenue = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.connexionButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bienvenue
            // 
            this.bienvenue.AutoSize = true;
            this.bienvenue.Font = new System.Drawing.Font("Sitka Text", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bienvenue.ForeColor = System.Drawing.Color.Orange;
            this.bienvenue.Location = new System.Drawing.Point(1125, 6);
            this.bienvenue.Name = "bienvenue";
            this.bienvenue.Size = new System.Drawing.Size(97, 49);
            this.bienvenue.TabIndex = 58;
            this.bienvenue.Text = "SIXT";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Orange;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.closeButton.Location = new System.Drawing.Point(681, 445);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(220, 78);
            this.closeButton.TabIndex = 57;
            this.closeButton.Text = "QUITTER";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // connexionButton
            // 
            this.connexionButton.BackColor = System.Drawing.Color.Orange;
            this.connexionButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.connexionButton.ForeColor = System.Drawing.SystemColors.Control;
            this.connexionButton.Location = new System.Drawing.Point(367, 445);
            this.connexionButton.Name = "connexionButton";
            this.connexionButton.Size = new System.Drawing.Size(220, 78);
            this.connexionButton.TabIndex = 56;
            this.connexionButton.Text = "CONNEXION";
            this.connexionButton.UseVisualStyleBackColor = false;
            this.connexionButton.Click += new System.EventHandler(this.connexionButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGray;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(434, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(426, 49);
            this.label4.TabIndex = 55;
            this.label4.Text = "Espace d\'authentification";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(649, 311);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(183, 23);
            this.password.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(391, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 35);
            this.label2.TabIndex = 53;
            this.label2.Text = "Mot de passe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(367, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 35);
            this.label1.TabIndex = 52;
            this.label1.Text = "Nom d\'utilisateur";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(649, 217);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(183, 23);
            this.username.TabIndex = 51;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1227, 571);
            this.Controls.Add(this.bienvenue);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.connexionButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.username);
            this.Name = "FormLogin";
            this.Text = "Page d\'authentification";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bienvenue;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button connexionButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username;
    }
}