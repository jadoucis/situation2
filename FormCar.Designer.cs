
namespace Car_Rental
{
    partial class FormCar
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
            this.idCarModel = new System.Windows.Forms.ComboBox();
            this.BoatTypeId_label = new System.Windows.Forms.Label();
            this.lvCarList = new System.Windows.Forms.ListView();
            this.RefreshText = new System.Windows.Forms.Button();
            this.UpdateCar = new System.Windows.Forms.Button();
            this.Leave = new System.Windows.Forms.Button();
            this.DeleteCar = new System.Windows.Forms.Button();
            this.AddCar = new System.Windows.Forms.Button();
            this.RentedCar = new System.Windows.Forms.CheckBox();
            this.PriceCar = new System.Windows.Forms.TextBox();
            this.NameCarModel = new System.Windows.Forms.ComboBox();
            this.DescriptionCar = new System.Windows.Forms.TextBox();
            this.SlotCar = new System.Windows.Forms.TextBox();
            this.LicenseCar = new System.Windows.Forms.TextBox();
            this.NameCar = new System.Windows.Forms.TextBox();
            this.CarDescription_label = new System.Windows.Forms.Label();
            this.Rented_label = new System.Windows.Forms.Label();
            this.CarPrice_label = new System.Windows.Forms.Label();
            this.CarModel_label = new System.Windows.Forms.Label();
            this.CarSlot_label = new System.Windows.Forms.Label();
            this.CarLicense_label = new System.Windows.Forms.Label();
            this.CarName_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateCommand = new System.Windows.Forms.Label();
            this.needRepared = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idCarModel
            // 
            this.idCarModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idCarModel.Enabled = false;
            this.idCarModel.FormattingEnabled = true;
            this.idCarModel.Location = new System.Drawing.Point(1304, 551);
            this.idCarModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.idCarModel.Name = "idCarModel";
            this.idCarModel.Size = new System.Drawing.Size(74, 28);
            this.idCarModel.TabIndex = 136;
            this.idCarModel.SelectedIndexChanged += new System.EventHandler(this.idCarModel_SelectedIndexChanged);
            // 
            // BoatTypeId_label
            // 
            this.BoatTypeId_label.AutoSize = true;
            this.BoatTypeId_label.BackColor = System.Drawing.Color.Wheat;
            this.BoatTypeId_label.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BoatTypeId_label.ForeColor = System.Drawing.Color.DarkOrange;
            this.BoatTypeId_label.Location = new System.Drawing.Point(1277, 494);
            this.BoatTypeId_label.Name = "BoatTypeId_label";
            this.BoatTypeId_label.Size = new System.Drawing.Size(45, 29);
            this.BoatTypeId_label.TabIndex = 135;
            this.BoatTypeId_label.Text = "Id :";
            // 
            // lvCarList
            // 
            this.lvCarList.FullRowSelect = true;
            this.lvCarList.GridLines = true;
            this.lvCarList.HideSelection = false;
            this.lvCarList.LabelWrap = false;
            this.lvCarList.Location = new System.Drawing.Point(34, 208);
            this.lvCarList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvCarList.Name = "lvCarList";
            this.lvCarList.Size = new System.Drawing.Size(687, 592);
            this.lvCarList.TabIndex = 134;
            this.lvCarList.UseCompatibleStateImageBehavior = false;
            this.lvCarList.View = System.Windows.Forms.View.Details;
            this.lvCarList.SelectedIndexChanged += new System.EventHandler(this.lvCarList_SelectedIndexChanged);
            this.lvCarList.DoubleClick += new System.EventHandler(this.lvCarList_DoubleClick);
            // 
            // RefreshText
            // 
            this.RefreshText.BackColor = System.Drawing.Color.DarkOrange;
            this.RefreshText.ForeColor = System.Drawing.SystemColors.Control;
            this.RefreshText.Location = new System.Drawing.Point(1167, 771);
            this.RefreshText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RefreshText.Name = "RefreshText";
            this.RefreshText.Size = new System.Drawing.Size(193, 55);
            this.RefreshText.TabIndex = 133;
            this.RefreshText.Text = "Rafraîchir la page";
            this.RefreshText.UseVisualStyleBackColor = false;
            this.RefreshText.Click += new System.EventHandler(this.RefreshText_Click);
            // 
            // UpdateCar
            // 
            this.UpdateCar.BackColor = System.Drawing.Color.DarkOrange;
            this.UpdateCar.ForeColor = System.Drawing.SystemColors.Control;
            this.UpdateCar.Location = new System.Drawing.Point(923, 771);
            this.UpdateCar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpdateCar.Name = "UpdateCar";
            this.UpdateCar.Size = new System.Drawing.Size(193, 55);
            this.UpdateCar.TabIndex = 132;
            this.UpdateCar.Text = "Modifier une voiture";
            this.UpdateCar.UseVisualStyleBackColor = false;
            this.UpdateCar.Click += new System.EventHandler(this.UpdateCar_Click);
            // 
            // Leave
            // 
            this.Leave.BackColor = System.Drawing.Color.DarkOrange;
            this.Leave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Leave.ForeColor = System.Drawing.SystemColors.Control;
            this.Leave.Location = new System.Drawing.Point(258, 827);
            this.Leave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Leave.Name = "Leave";
            this.Leave.Size = new System.Drawing.Size(250, 56);
            this.Leave.TabIndex = 131;
            this.Leave.Text = "Quitter";
            this.Leave.UseVisualStyleBackColor = false;
            this.Leave.Click += new System.EventHandler(this.Leave_Click);
            // 
            // DeleteCar
            // 
            this.DeleteCar.BackColor = System.Drawing.Color.DarkOrange;
            this.DeleteCar.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteCar.Location = new System.Drawing.Point(1167, 690);
            this.DeleteCar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteCar.Name = "DeleteCar";
            this.DeleteCar.Size = new System.Drawing.Size(193, 55);
            this.DeleteCar.TabIndex = 130;
            this.DeleteCar.Text = "Supprimer une voiture";
            this.DeleteCar.UseVisualStyleBackColor = false;
            this.DeleteCar.Click += new System.EventHandler(this.DeleteCar_Click);
            // 
            // AddCar
            // 
            this.AddCar.BackColor = System.Drawing.Color.DarkOrange;
            this.AddCar.ForeColor = System.Drawing.SystemColors.Control;
            this.AddCar.Location = new System.Drawing.Point(923, 690);
            this.AddCar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddCar.Name = "AddCar";
            this.AddCar.Size = new System.Drawing.Size(193, 55);
            this.AddCar.TabIndex = 129;
            this.AddCar.Text = "Ajouter une voiture";
            this.AddCar.UseVisualStyleBackColor = false;
            this.AddCar.Click += new System.EventHandler(this.AddCar_Click);
            // 
            // RentedCar
            // 
            this.RentedCar.AutoSize = true;
            this.RentedCar.Location = new System.Drawing.Point(1167, 635);
            this.RentedCar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RentedCar.Name = "RentedCar";
            this.RentedCar.Size = new System.Drawing.Size(18, 17);
            this.RentedCar.TabIndex = 128;
            this.RentedCar.UseVisualStyleBackColor = true;
            // 
            // PriceCar
            // 
            this.PriceCar.Location = new System.Drawing.Point(1092, 562);
            this.PriceCar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PriceCar.Name = "PriceCar";
            this.PriceCar.PlaceholderText = "1000";
            this.PriceCar.Size = new System.Drawing.Size(165, 27);
            this.PriceCar.TabIndex = 127;
            this.PriceCar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NameCarModel
            // 
            this.NameCarModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NameCarModel.FormattingEnabled = true;
            this.NameCarModel.Location = new System.Drawing.Point(1092, 498);
            this.NameCarModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameCarModel.Name = "NameCarModel";
            this.NameCarModel.Size = new System.Drawing.Size(165, 28);
            this.NameCarModel.TabIndex = 126;
            this.NameCarModel.SelectedIndexChanged += new System.EventHandler(this.NameCarModel_SelectedIndexChanged);
            // 
            // DescriptionCar
            // 
            this.DescriptionCar.Location = new System.Drawing.Point(1075, 367);
            this.DescriptionCar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DescriptionCar.Multiline = true;
            this.DescriptionCar.Name = "DescriptionCar";
            this.DescriptionCar.PlaceholderText = "La meilleure Porsche sur le marché";
            this.DescriptionCar.Size = new System.Drawing.Size(243, 89);
            this.DescriptionCar.TabIndex = 125;
            this.DescriptionCar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SlotCar
            // 
            this.SlotCar.Location = new System.Drawing.Point(1092, 307);
            this.SlotCar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SlotCar.Name = "SlotCar";
            this.SlotCar.PlaceholderText = "4";
            this.SlotCar.Size = new System.Drawing.Size(165, 27);
            this.SlotCar.TabIndex = 124;
            this.SlotCar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LicenseCar
            // 
            this.LicenseCar.Location = new System.Drawing.Point(1092, 248);
            this.LicenseCar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LicenseCar.Name = "LicenseCar";
            this.LicenseCar.PlaceholderText = "XZY 312 655 34";
            this.LicenseCar.Size = new System.Drawing.Size(165, 27);
            this.LicenseCar.TabIndex = 123;
            this.LicenseCar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NameCar
            // 
            this.NameCar.Location = new System.Drawing.Point(1092, 174);
            this.NameCar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameCar.Name = "NameCar";
            this.NameCar.PlaceholderText = "CarreraGT";
            this.NameCar.Size = new System.Drawing.Size(165, 27);
            this.NameCar.TabIndex = 122;
            this.NameCar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CarDescription_label
            // 
            this.CarDescription_label.AutoSize = true;
            this.CarDescription_label.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarDescription_label.ForeColor = System.Drawing.Color.DarkOrange;
            this.CarDescription_label.Location = new System.Drawing.Point(823, 403);
            this.CarDescription_label.Name = "CarDescription_label";
            this.CarDescription_label.Size = new System.Drawing.Size(257, 29);
            this.CarDescription_label.TabIndex = 121;
            this.CarDescription_label.Text = "Description de la voiture :";
            // 
            // Rented_label
            // 
            this.Rented_label.AutoSize = true;
            this.Rented_label.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Rented_label.ForeColor = System.Drawing.Color.DarkOrange;
            this.Rented_label.Location = new System.Drawing.Point(882, 626);
            this.Rented_label.Name = "Rented_label";
            this.Rented_label.Size = new System.Drawing.Size(192, 29);
            this.Rented_label.TabIndex = 120;
            this.Rented_label.Text = "Location en cours :";
            // 
            // CarPrice_label
            // 
            this.CarPrice_label.AutoSize = true;
            this.CarPrice_label.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarPrice_label.ForeColor = System.Drawing.Color.DarkOrange;
            this.CarPrice_label.Location = new System.Drawing.Point(773, 562);
            this.CarPrice_label.Name = "CarPrice_label";
            this.CarPrice_label.Size = new System.Drawing.Size(309, 29);
            this.CarPrice_label.TabIndex = 119;
            this.CarPrice_label.Text = "Prix de la voiture à la location :";
            // 
            // CarModel_label
            // 
            this.CarModel_label.AutoSize = true;
            this.CarModel_label.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarModel_label.ForeColor = System.Drawing.Color.DarkOrange;
            this.CarModel_label.Location = new System.Drawing.Point(853, 494);
            this.CarModel_label.Name = "CarModel_label";
            this.CarModel_label.Size = new System.Drawing.Size(221, 29);
            this.CarModel_label.TabIndex = 118;
            this.CarModel_label.Text = "Marque de la voiture :";
            // 
            // CarSlot_label
            // 
            this.CarSlot_label.AutoSize = true;
            this.CarSlot_label.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarSlot_label.ForeColor = System.Drawing.Color.DarkOrange;
            this.CarSlot_label.Location = new System.Drawing.Point(866, 307);
            this.CarSlot_label.Name = "CarSlot_label";
            this.CarSlot_label.Size = new System.Drawing.Size(193, 29);
            this.CarSlot_label.TabIndex = 117;
            this.CarSlot_label.Text = "Nombre de portes :";
            // 
            // CarLicense_label
            // 
            this.CarLicense_label.AutoSize = true;
            this.CarLicense_label.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarLicense_label.ForeColor = System.Drawing.Color.DarkOrange;
            this.CarLicense_label.Location = new System.Drawing.Point(861, 244);
            this.CarLicense_label.Name = "CarLicense_label";
            this.CarLicense_label.Size = new System.Drawing.Size(212, 29);
            this.CarLicense_label.TabIndex = 116;
            this.CarLicense_label.Text = "Plaque de la voiture :";
            // 
            // CarName_label
            // 
            this.CarName_label.AutoSize = true;
            this.CarName_label.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarName_label.ForeColor = System.Drawing.Color.DarkOrange;
            this.CarName_label.Location = new System.Drawing.Point(866, 174);
            this.CarName_label.Name = "CarName_label";
            this.CarName_label.Size = new System.Drawing.Size(194, 29);
            this.CarName_label.TabIndex = 115;
            this.CarName_label.Text = "Nom de la voiture :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(258, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 40);
            this.label1.TabIndex = 114;
            this.label1.Text = "Liste des voitures";
            // 
            // CreateCommand
            // 
            this.CreateCommand.AutoSize = true;
            this.CreateCommand.Font = new System.Drawing.Font("Sitka Text", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateCommand.ForeColor = System.Drawing.Color.DarkOrange;
            this.CreateCommand.Location = new System.Drawing.Point(1004, 90);
            this.CreateCommand.Name = "CreateCommand";
            this.CreateCommand.Size = new System.Drawing.Size(277, 40);
            this.CreateCommand.TabIndex = 113;
            this.CreateCommand.Text = "Ajouter une voiture";
            // 
            // needRepared
            // 
            this.needRepared.AutoSize = true;
            this.needRepared.Location = new System.Drawing.Point(853, 851);
            this.needRepared.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.needRepared.Name = "needRepared";
            this.needRepared.Size = new System.Drawing.Size(18, 17);
            this.needRepared.TabIndex = 138;
            this.needRepared.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(624, 839);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 29);
            this.label2.TabIndex = 137;
            this.label2.Text = "Réparation en cours";
            // 
            // FormCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1466, 1055);
            this.Controls.Add(this.needRepared);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idCarModel);
            this.Controls.Add(this.BoatTypeId_label);
            this.Controls.Add(this.lvCarList);
            this.Controls.Add(this.RefreshText);
            this.Controls.Add(this.UpdateCar);
            this.Controls.Add(this.Leave);
            this.Controls.Add(this.DeleteCar);
            this.Controls.Add(this.AddCar);
            this.Controls.Add(this.RentedCar);
            this.Controls.Add(this.PriceCar);
            this.Controls.Add(this.NameCarModel);
            this.Controls.Add(this.DescriptionCar);
            this.Controls.Add(this.SlotCar);
            this.Controls.Add(this.LicenseCar);
            this.Controls.Add(this.NameCar);
            this.Controls.Add(this.CarDescription_label);
            this.Controls.Add(this.Rented_label);
            this.Controls.Add(this.CarPrice_label);
            this.Controls.Add(this.CarModel_label);
            this.Controls.Add(this.CarSlot_label);
            this.Controls.Add(this.CarLicense_label);
            this.Controls.Add(this.CarName_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateCommand);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCar";
            this.Text = "Gestionnaire de véhicules";
            this.Load += new System.EventHandler(this.FormCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox idCarModel;
        private System.Windows.Forms.Label BoatTypeId_label;
        private System.Windows.Forms.ListView lvCarList;
        private System.Windows.Forms.Button RefreshText;
        private System.Windows.Forms.Button UpdateCar;
        private System.Windows.Forms.Button Leave;
        private System.Windows.Forms.Button DeleteCar;
        private System.Windows.Forms.Button AddCar;
        private System.Windows.Forms.CheckBox RentedCar;
        private System.Windows.Forms.TextBox PriceCar;
        private System.Windows.Forms.ComboBox NameCarModel;
        private System.Windows.Forms.TextBox DescriptionCar;
        private System.Windows.Forms.TextBox SlotCar;
        private System.Windows.Forms.TextBox LicenseCar;
        private System.Windows.Forms.TextBox NameCar;
        private System.Windows.Forms.Label CarDescription_label;
        private System.Windows.Forms.Label Rented_label;
        private System.Windows.Forms.Label CarPrice_label;
        private System.Windows.Forms.Label CarModel_label;
        private System.Windows.Forms.Label CarSlot_label;
        private System.Windows.Forms.Label CarLicense_label;
        private System.Windows.Forms.Label CarName_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CreateCommand;
        private System.Windows.Forms.CheckBox needRepared;
        private System.Windows.Forms.Label label2;
    }
}