
namespace Car_Rental
{
    partial class FormCustomer
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
            this.button_Leave = new System.Windows.Forms.Button();
            this.list_customer = new System.Windows.Forms.ListView();
            this.date_naissance = new System.Windows.Forms.DateTimePicker();
            this.rentChecked = new System.Windows.Forms.CheckBox();
            this.licenseChecked = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mailAdress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Leave
            // 
            this.button_Leave.BackColor = System.Drawing.Color.DarkOrange;
            this.button_Leave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Leave.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Leave.Location = new System.Drawing.Point(239, 659);
            this.button_Leave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Leave.Name = "button_Leave";
            this.button_Leave.Size = new System.Drawing.Size(228, 41);
            this.button_Leave.TabIndex = 99;
            this.button_Leave.Text = "Quitter";
            this.button_Leave.UseVisualStyleBackColor = false;
            this.button_Leave.Click += new System.EventHandler(this.button_Leave_Click);
            // 
            // list_customer
            // 
            this.list_customer.FullRowSelect = true;
            this.list_customer.GridLines = true;
            this.list_customer.HideSelection = false;
            this.list_customer.Location = new System.Drawing.Point(41, 167);
            this.list_customer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.list_customer.Name = "list_customer";
            this.list_customer.Size = new System.Drawing.Size(629, 443);
            this.list_customer.TabIndex = 98;
            this.list_customer.UseCompatibleStateImageBehavior = false;
            this.list_customer.View = System.Windows.Forms.View.Details;
            this.list_customer.DoubleClick += new System.EventHandler(this.list_customer_DoubleClick);
            // 
            // date_naissance
            // 
            this.date_naissance.CustomFormat = "dd-MM-yyyy";
            this.date_naissance.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_naissance.ImeMode = System.Windows.Forms.ImeMode.On;
            this.date_naissance.Location = new System.Drawing.Point(1026, 281);
            this.date_naissance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_naissance.Name = "date_naissance";
            this.date_naissance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.date_naissance.Size = new System.Drawing.Size(113, 27);
            this.date_naissance.TabIndex = 97;
            this.date_naissance.Value = new System.DateTime(2002, 8, 11, 0, 0, 0, 0);
            // 
            // rentChecked
            // 
            this.rentChecked.AutoSize = true;
            this.rentChecked.Location = new System.Drawing.Point(1070, 475);
            this.rentChecked.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rentChecked.Name = "rentChecked";
            this.rentChecked.Size = new System.Drawing.Size(18, 17);
            this.rentChecked.TabIndex = 96;
            this.rentChecked.UseVisualStyleBackColor = true;
            // 
            // licenseChecked
            // 
            this.licenseChecked.AutoSize = true;
            this.licenseChecked.Location = new System.Drawing.Point(1070, 411);
            this.licenseChecked.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.licenseChecked.Name = "licenseChecked";
            this.licenseChecked.Size = new System.Drawing.Size(18, 17);
            this.licenseChecked.TabIndex = 95;
            this.licenseChecked.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.DarkOrange;
            this.label9.Location = new System.Drawing.Point(814, 463);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 29);
            this.label9.TabIndex = 94;
            this.label9.Text = "Location en cours";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.DarkOrange;
            this.label8.Location = new System.Drawing.Point(827, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 29);
            this.label8.TabIndex = 93;
            this.label8.Text = "Permis Voiture";
            // 
            // mailAdress
            // 
            this.mailAdress.Location = new System.Drawing.Point(999, 341);
            this.mailAdress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mailAdress.Multiline = true;
            this.mailAdress.Name = "mailAdress";
            this.mailAdress.PlaceholderText = "marc.leflambeau@laflamme.canalplus";
            this.mailAdress.Size = new System.Drawing.Size(270, 29);
            this.mailAdress.TabIndex = 92;
            this.mailAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(827, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 29);
            this.label6.TabIndex = 91;
            this.label6.Text = "Adresse mail";
            // 
            // button_Reset
            // 
            this.button_Reset.BackColor = System.Drawing.Color.DarkOrange;
            this.button_Reset.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Reset.Location = new System.Drawing.Point(1115, 623);
            this.button_Reset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(198, 55);
            this.button_Reset.TabIndex = 90;
            this.button_Reset.Text = "Réinitialiser";
            this.button_Reset.UseVisualStyleBackColor = false;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.DarkOrange;
            this.button_Delete.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Delete.Location = new System.Drawing.Point(1115, 533);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(198, 55);
            this.button_Delete.TabIndex = 89;
            this.button_Delete.Text = "Supprimer un client";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.Color.DarkOrange;
            this.button_Update.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Update.Location = new System.Drawing.Point(842, 623);
            this.button_Update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(198, 55);
            this.button_Update.TabIndex = 88;
            this.button_Update.Text = "Modifier un client";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(814, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 29);
            this.label5.TabIndex = 87;
            this.label5.Text = "Date anniversaire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(831, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 29);
            this.label3.TabIndex = 86;
            this.label3.Text = "Nom de famille";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(239, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 40);
            this.label1.TabIndex = 85;
            this.label1.Text = "Liste des clients";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(862, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 29);
            this.label2.TabIndex = 84;
            this.label2.Text = "Prénom";
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.DarkOrange;
            this.button_Add.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Add.Location = new System.Drawing.Point(842, 533);
            this.button_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(198, 55);
            this.button_Add.TabIndex = 83;
            this.button_Add.Text = "Ajouter un client";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(999, 225);
            this.lastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastName.Multiline = true;
            this.lastName.Name = "lastName";
            this.lastName.PlaceholderText = "LeFlambeau";
            this.lastName.Size = new System.Drawing.Size(173, 29);
            this.lastName.TabIndex = 82;
            this.lastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(999, 159);
            this.firstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstName.Multiline = true;
            this.firstName.Name = "firstName";
            this.firstName.PlaceholderText = "Marc";
            this.firstName.Size = new System.Drawing.Size(175, 29);
            this.firstName.TabIndex = 81;
            this.firstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(983, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 40);
            this.label4.TabIndex = 80;
            this.label4.Text = "Ajouter un client";
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1400, 760);
            this.Controls.Add(this.button_Leave);
            this.Controls.Add(this.list_customer);
            this.Controls.Add(this.date_naissance);
            this.Controls.Add(this.rentChecked);
            this.Controls.Add(this.licenseChecked);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mailAdress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCustomer";
            this.Text = "Gestionnaire des clients";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Leave;
        private System.Windows.Forms.ListView list_customer;
        private System.Windows.Forms.DateTimePicker date_naissance;
        private System.Windows.Forms.CheckBox rentChecked;
        private System.Windows.Forms.CheckBox licenseChecked;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox mailAdress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label4;
    }
}