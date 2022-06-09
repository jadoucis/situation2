
namespace Car_Rental
{
    partial class FormCommand
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
            this.label6 = new System.Windows.Forms.Label();
            this.montantTTC_text = new System.Windows.Forms.TextBox();
            this.boolPaied = new System.Windows.Forms.CheckBox();
            this.listeNom = new System.Windows.Forms.ComboBox();
            this.idCar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.priceCar = new System.Windows.Forms.TextBox();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.listeCar = new System.Windows.Forms.ComboBox();
            this.listeIdentifiant = new System.Windows.Forms.ComboBox();
            this.dateDeb = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cautionCommand = new System.Windows.Forms.Label();
            this.totalCommand = new System.Windows.Forms.Label();
            this.CarName = new System.Windows.Forms.Label();
            this.lvCommand = new System.Windows.Forms.ListView();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.idCommandPerson = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameCommand = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.CreateCommand = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Orange;
            this.label6.Location = new System.Drawing.Point(1401, 521);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 29);
            this.label6.TabIndex = 113;
            this.label6.Text = "TTC :";
            // 
            // montantTTC_text
            // 
            this.montantTTC_text.Location = new System.Drawing.Point(1471, 527);
            this.montantTTC_text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.montantTTC_text.Name = "montantTTC_text";
            this.montantTTC_text.Size = new System.Drawing.Size(138, 27);
            this.montantTTC_text.TabIndex = 112;
            // 
            // boolPaied
            // 
            this.boolPaied.AutoSize = true;
            this.boolPaied.Location = new System.Drawing.Point(1335, 477);
            this.boolPaied.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boolPaied.Name = "boolPaied";
            this.boolPaied.Size = new System.Drawing.Size(18, 17);
            this.boolPaied.TabIndex = 111;
            this.boolPaied.UseVisualStyleBackColor = true;
            // 
            // listeNom
            // 
            this.listeNom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listeNom.FormattingEnabled = true;
            this.listeNom.Location = new System.Drawing.Point(1285, 93);
            this.listeNom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listeNom.Name = "listeNom";
            this.listeNom.Size = new System.Drawing.Size(138, 28);
            this.listeNom.TabIndex = 110;
            this.listeNom.SelectedIndexChanged += new System.EventHandler(this.listeNom_SelectedIndexChanged);
            // 
            // idCar
            // 
            this.idCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idCar.Enabled = false;
            this.idCar.FormattingEnabled = true;
            this.idCar.Location = new System.Drawing.Point(1285, 284);
            this.idCar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.idCar.Name = "idCar";
            this.idCar.Size = new System.Drawing.Size(138, 28);
            this.idCar.TabIndex = 109;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(992, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 29);
            this.label4.TabIndex = 108;
            this.label4.Text = "Identifiant de la voiture :";
            // 
            // priceCar
            // 
            this.priceCar.Location = new System.Drawing.Point(1250, 525);
            this.priceCar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.priceCar.Name = "priceCar";
            this.priceCar.ReadOnly = true;
            this.priceCar.Size = new System.Drawing.Size(138, 27);
            this.priceCar.TabIndex = 107;
            this.priceCar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateFin
            // 
            this.dateFin.CustomFormat = "dd-MM-yyyy tt H:mm:ss";
            this.dateFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFin.Location = new System.Drawing.Point(1286, 411);
            this.dateFin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(169, 27);
            this.dateFin.TabIndex = 106;
            this.dateFin.Value = new System.DateTime(2022, 6, 6, 0, 0, 0, 0);
            // 
            // listeCar
            // 
            this.listeCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listeCar.FormattingEnabled = true;
            this.listeCar.Location = new System.Drawing.Point(1285, 229);
            this.listeCar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listeCar.Name = "listeCar";
            this.listeCar.Size = new System.Drawing.Size(138, 28);
            this.listeCar.TabIndex = 105;
            this.listeCar.SelectedIndexChanged += new System.EventHandler(this.listeCar_SelectedIndexChanged);
            // 
            // listeIdentifiant
            // 
            this.listeIdentifiant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listeIdentifiant.Enabled = false;
            this.listeIdentifiant.FormattingEnabled = true;
            this.listeIdentifiant.Location = new System.Drawing.Point(1285, 163);
            this.listeIdentifiant.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listeIdentifiant.Name = "listeIdentifiant";
            this.listeIdentifiant.Size = new System.Drawing.Size(138, 28);
            this.listeIdentifiant.TabIndex = 104;
            this.listeIdentifiant.SelectedIndexChanged += new System.EventHandler(this.listeIdentifiant_SelectedIndexChanged);
            // 
            // dateDeb
            // 
            this.dateDeb.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateDeb.CustomFormat = "dd-MM-yyyy tt H:mm:ss";
            this.dateDeb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDeb.Location = new System.Drawing.Point(1286, 344);
            this.dateDeb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateDeb.Name = "dateDeb";
            this.dateDeb.Size = new System.Drawing.Size(169, 27);
            this.dateDeb.TabIndex = 103;
            this.dateDeb.Value = new System.DateTime(2022, 6, 6, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(1029, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 29);
            this.label3.TabIndex = 102;
            this.label3.Text = "Date et heure de fin :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(1002, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 29);
            this.label2.TabIndex = 101;
            this.label2.Text = "Date et heure du début :";
            // 
            // cautionCommand
            // 
            this.cautionCommand.AutoSize = true;
            this.cautionCommand.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cautionCommand.ForeColor = System.Drawing.Color.Orange;
            this.cautionCommand.Location = new System.Drawing.Point(992, 468);
            this.cautionCommand.Name = "cautionCommand";
            this.cautionCommand.Size = new System.Drawing.Size(252, 29);
            this.cautionCommand.TabIndex = 100;
            this.cautionCommand.Text = "Caution réglée sur place :";
            // 
            // totalCommand
            // 
            this.totalCommand.AutoSize = true;
            this.totalCommand.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalCommand.ForeColor = System.Drawing.Color.Orange;
            this.totalCommand.Location = new System.Drawing.Point(971, 525);
            this.totalCommand.Name = "totalCommand";
            this.totalCommand.Size = new System.Drawing.Size(267, 29);
            this.totalCommand.TabIndex = 99;
            this.totalCommand.Text = "Total de la commande HT :";
            // 
            // CarName
            // 
            this.CarName.AutoSize = true;
            this.CarName.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarName.ForeColor = System.Drawing.Color.Orange;
            this.CarName.Location = new System.Drawing.Point(1002, 224);
            this.CarName.Name = "CarName";
            this.CarName.Size = new System.Drawing.Size(234, 29);
            this.CarName.TabIndex = 98;
            this.CarName.Text = "Sélection de la voiture :";
            // 
            // lvCommand
            // 
            this.lvCommand.FullRowSelect = true;
            this.lvCommand.GridLines = true;
            this.lvCommand.HideSelection = false;
            this.lvCommand.Location = new System.Drawing.Point(31, 84);
            this.lvCommand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvCommand.Name = "lvCommand";
            this.lvCommand.Size = new System.Drawing.Size(827, 533);
            this.lvCommand.TabIndex = 97;
            this.lvCommand.UseCompatibleStateImageBehavior = false;
            this.lvCommand.View = System.Windows.Forms.View.Details;
            this.lvCommand.DoubleClick += new System.EventHandler(this.lvCommand_DoubleClick);
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(689, 689);
            this.button_Reset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(295, 55);
            this.button_Reset.TabIndex = 96;
            this.button_Reset.Text = "Quitter";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(1415, 591);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(198, 55);
            this.button_Delete.TabIndex = 95;
            this.button_Delete.Text = "Supprimer une commande";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(1191, 591);
            this.button_Update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(198, 55);
            this.button_Update.TabIndex = 94;
            this.button_Update.Text = "Modifier une commande";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // idCommandPerson
            // 
            this.idCommandPerson.AutoSize = true;
            this.idCommandPerson.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idCommandPerson.ForeColor = System.Drawing.Color.Orange;
            this.idCommandPerson.Location = new System.Drawing.Point(978, 157);
            this.idCommandPerson.Name = "idCommandPerson";
            this.idCommandPerson.Size = new System.Drawing.Size(268, 29);
            this.idCommandPerson.TabIndex = 93;
            this.idCommandPerson.Text = "Identifiant de la personne :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(334, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 40);
            this.label1.TabIndex = 92;
            this.label1.Text = "Liste des commandes";
            // 
            // nameCommand
            // 
            this.nameCommand.AutoSize = true;
            this.nameCommand.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameCommand.ForeColor = System.Drawing.Color.Orange;
            this.nameCommand.Location = new System.Drawing.Point(1030, 89);
            this.nameCommand.Name = "nameCommand";
            this.nameCommand.Size = new System.Drawing.Size(212, 29);
            this.nameCommand.TabIndex = 91;
            this.nameCommand.Text = "Nom de la personne :";
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(955, 591);
            this.button_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(198, 55);
            this.button_Add.TabIndex = 90;
            this.button_Add.Text = "Créer la commande";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // CreateCommand
            // 
            this.CreateCommand.AutoSize = true;
            this.CreateCommand.Font = new System.Drawing.Font("Sitka Text", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateCommand.ForeColor = System.Drawing.Color.Orange;
            this.CreateCommand.Location = new System.Drawing.Point(1125, 12);
            this.CreateCommand.Name = "CreateCommand";
            this.CreateCommand.Size = new System.Drawing.Size(298, 40);
            this.CreateCommand.TabIndex = 89;
            this.CreateCommand.Text = "Créer une commande";
            // 
            // FormCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1651, 760);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.montantTTC_text);
            this.Controls.Add(this.boolPaied);
            this.Controls.Add(this.listeNom);
            this.Controls.Add(this.idCar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.priceCar);
            this.Controls.Add(this.dateFin);
            this.Controls.Add(this.listeCar);
            this.Controls.Add(this.listeIdentifiant);
            this.Controls.Add(this.dateDeb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cautionCommand);
            this.Controls.Add(this.totalCommand);
            this.Controls.Add(this.CarName);
            this.Controls.Add(this.lvCommand);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.idCommandPerson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameCommand);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.CreateCommand);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCommand";
            this.Text = "Gestionnaire des commandes clientes";
            this.Load += new System.EventHandler(this.FormCommand_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox montantTTC_text;
        private System.Windows.Forms.CheckBox boolPaied;
        private System.Windows.Forms.ComboBox listeNom;
        private System.Windows.Forms.ComboBox idCar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox priceCar;
        private System.Windows.Forms.DateTimePicker dateFin;
        private System.Windows.Forms.ComboBox listeCar;
        private System.Windows.Forms.ComboBox listeIdentifiant;
        private System.Windows.Forms.DateTimePicker dateDeb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cautionCommand;
        private System.Windows.Forms.Label totalCommand;
        private System.Windows.Forms.Label CarName;
        private System.Windows.Forms.ListView lvCommand;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Label idCommandPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameCommand;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Label CreateCommand;
    }
}