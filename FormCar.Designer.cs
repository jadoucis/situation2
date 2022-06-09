
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
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idCarModel
            // 
            this.idCarModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idCarModel.Enabled = false;
            this.idCarModel.FormattingEnabled = true;
            this.idCarModel.Location = new System.Drawing.Point(1141, 413);
            this.idCarModel.Name = "idCarModel";
            this.idCarModel.Size = new System.Drawing.Size(65, 23);
            this.idCarModel.TabIndex = 136;
            this.idCarModel.SelectedIndexChanged += new System.EventHandler(this.idCarModel_SelectedIndexChanged);
            // 
            // BoatTypeId_label
            // 
            this.BoatTypeId_label.AutoSize = true;
            this.BoatTypeId_label.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BoatTypeId_label.ForeColor = System.Drawing.SystemColors.Control;
            this.BoatTypeId_label.Location = new System.Drawing.Point(1099, 413);
            this.BoatTypeId_label.Name = "BoatTypeId_label";
            this.BoatTypeId_label.Size = new System.Drawing.Size(36, 23);
            this.BoatTypeId_label.TabIndex = 135;
            this.BoatTypeId_label.Text = "Id :";
            // 
            // lvCarList
            // 
            this.lvCarList.FullRowSelect = true;
            this.lvCarList.GridLines = true;
            this.lvCarList.HideSelection = false;
            this.lvCarList.LabelWrap = false;
            this.lvCarList.Location = new System.Drawing.Point(30, 156);
            this.lvCarList.Name = "lvCarList";
            this.lvCarList.Size = new System.Drawing.Size(602, 445);
            this.lvCarList.TabIndex = 134;
            this.lvCarList.UseCompatibleStateImageBehavior = false;
            this.lvCarList.View = System.Windows.Forms.View.Details;
            this.lvCarList.DoubleClick += new System.EventHandler(this.lvCarList_DoubleClick);
            // 
            // RefreshText
            // 
            this.RefreshText.Location = new System.Drawing.Point(1003, 621);
            this.RefreshText.Name = "RefreshText";
            this.RefreshText.Size = new System.Drawing.Size(169, 41);
            this.RefreshText.TabIndex = 133;
            this.RefreshText.Text = "Rafraîchir la page";
            this.RefreshText.UseVisualStyleBackColor = true;
            this.RefreshText.Click += new System.EventHandler(this.RefreshText_Click);
            // 
            // UpdateCar
            // 
            this.UpdateCar.Location = new System.Drawing.Point(789, 621);
            this.UpdateCar.Name = "UpdateCar";
            this.UpdateCar.Size = new System.Drawing.Size(169, 41);
            this.UpdateCar.TabIndex = 132;
            this.UpdateCar.Text = "Modifier une voiture";
            this.UpdateCar.UseVisualStyleBackColor = true;
            this.UpdateCar.Click += new System.EventHandler(this.UpdateCar_Click);
            // 
            // Leave
            // 
            this.Leave.Location = new System.Drawing.Point(480, 710);
            this.Leave.Name = "Leave";
            this.Leave.Size = new System.Drawing.Size(258, 42);
            this.Leave.TabIndex = 131;
            this.Leave.Text = "Quitter";
            this.Leave.UseVisualStyleBackColor = true;
            this.Leave.Click += new System.EventHandler(this.Leave_Click);
            // 
            // DeleteCar
            // 
            this.DeleteCar.Location = new System.Drawing.Point(1003, 560);
            this.DeleteCar.Name = "DeleteCar";
            this.DeleteCar.Size = new System.Drawing.Size(169, 41);
            this.DeleteCar.TabIndex = 130;
            this.DeleteCar.Text = "Supprimer une voiture";
            this.DeleteCar.UseVisualStyleBackColor = true;
            this.DeleteCar.Click += new System.EventHandler(this.DeleteCar_Click);
            // 
            // AddCar
            // 
            this.AddCar.Location = new System.Drawing.Point(789, 560);
            this.AddCar.Name = "AddCar";
            this.AddCar.Size = new System.Drawing.Size(169, 41);
            this.AddCar.TabIndex = 129;
            this.AddCar.Text = "Ajouter une voiture";
            this.AddCar.UseVisualStyleBackColor = true;
            this.AddCar.Click += new System.EventHandler(this.AddCar_Click);
            // 
            // RentedCar
            // 
            this.RentedCar.AutoSize = true;
            this.RentedCar.Location = new System.Drawing.Point(1003, 519);
            this.RentedCar.Name = "RentedCar";
            this.RentedCar.Size = new System.Drawing.Size(15, 14);
            this.RentedCar.TabIndex = 128;
            this.RentedCar.UseVisualStyleBackColor = true;
            // 
            // PriceCar
            // 
            this.PriceCar.Location = new System.Drawing.Point(937, 464);
            this.PriceCar.Name = "PriceCar";
            this.PriceCar.PlaceholderText = "1000";
            this.PriceCar.Size = new System.Drawing.Size(145, 23);
            this.PriceCar.TabIndex = 127;
            this.PriceCar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NameCarModel
            // 
            this.NameCarModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NameCarModel.FormattingEnabled = true;
            this.NameCarModel.Location = new System.Drawing.Point(937, 416);
            this.NameCarModel.Name = "NameCarModel";
            this.NameCarModel.Size = new System.Drawing.Size(145, 23);
            this.NameCarModel.TabIndex = 126;
            this.NameCarModel.SelectedIndexChanged += new System.EventHandler(this.NameCarModel_SelectedIndexChanged);
            // 
            // DescriptionCar
            // 
            this.DescriptionCar.Location = new System.Drawing.Point(922, 318);
            this.DescriptionCar.Multiline = true;
            this.DescriptionCar.Name = "DescriptionCar";
            this.DescriptionCar.PlaceholderText = "La meilleure Porsche sur la marché";
            this.DescriptionCar.Size = new System.Drawing.Size(213, 68);
            this.DescriptionCar.TabIndex = 125;
            this.DescriptionCar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SlotCar
            // 
            this.SlotCar.Location = new System.Drawing.Point(937, 273);
            this.SlotCar.Name = "SlotCar";
            this.SlotCar.PlaceholderText = "4";
            this.SlotCar.Size = new System.Drawing.Size(145, 23);
            this.SlotCar.TabIndex = 124;
            this.SlotCar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LicenseCar
            // 
            this.LicenseCar.Location = new System.Drawing.Point(937, 229);
            this.LicenseCar.Name = "LicenseCar";
            this.LicenseCar.PlaceholderText = "XZY 312 655 34";
            this.LicenseCar.Size = new System.Drawing.Size(145, 23);
            this.LicenseCar.TabIndex = 123;
            this.LicenseCar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NameCar
            // 
            this.NameCar.Location = new System.Drawing.Point(937, 173);
            this.NameCar.Name = "NameCar";
            this.NameCar.PlaceholderText = "CarreraGT";
            this.NameCar.Size = new System.Drawing.Size(145, 23);
            this.NameCar.TabIndex = 122;
            this.NameCar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CarDescription_label
            // 
            this.CarDescription_label.AutoSize = true;
            this.CarDescription_label.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarDescription_label.ForeColor = System.Drawing.Color.Orange;
            this.CarDescription_label.Location = new System.Drawing.Point(702, 345);
            this.CarDescription_label.Name = "CarDescription_label";
            this.CarDescription_label.Size = new System.Drawing.Size(206, 23);
            this.CarDescription_label.TabIndex = 121;
            this.CarDescription_label.Text = "Description de la voiture :";
            // 
            // Rented_label
            // 
            this.Rented_label.AutoSize = true;
            this.Rented_label.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Rented_label.ForeColor = System.Drawing.Color.Orange;
            this.Rented_label.Location = new System.Drawing.Point(753, 512);
            this.Rented_label.Name = "Rented_label";
            this.Rented_label.Size = new System.Drawing.Size(155, 23);
            this.Rented_label.TabIndex = 120;
            this.Rented_label.Text = "Location en cours :";
            // 
            // CarPrice_label
            // 
            this.CarPrice_label.AutoSize = true;
            this.CarPrice_label.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarPrice_label.ForeColor = System.Drawing.Color.Orange;
            this.CarPrice_label.Location = new System.Drawing.Point(658, 464);
            this.CarPrice_label.Name = "CarPrice_label";
            this.CarPrice_label.Size = new System.Drawing.Size(250, 23);
            this.CarPrice_label.TabIndex = 119;
            this.CarPrice_label.Text = "Prix de la voiture à la location :";
            // 
            // CarModel_label
            // 
            this.CarModel_label.AutoSize = true;
            this.CarModel_label.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarModel_label.ForeColor = System.Drawing.Color.Orange;
            this.CarModel_label.Location = new System.Drawing.Point(728, 413);
            this.CarModel_label.Name = "CarModel_label";
            this.CarModel_label.Size = new System.Drawing.Size(178, 23);
            this.CarModel_label.TabIndex = 118;
            this.CarModel_label.Text = "Marque de la voiture :";
            // 
            // CarSlot_label
            // 
            this.CarSlot_label.AutoSize = true;
            this.CarSlot_label.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarSlot_label.ForeColor = System.Drawing.Color.Orange;
            this.CarSlot_label.Location = new System.Drawing.Point(739, 273);
            this.CarSlot_label.Name = "CarSlot_label";
            this.CarSlot_label.Size = new System.Drawing.Size(153, 23);
            this.CarSlot_label.TabIndex = 117;
            this.CarSlot_label.Text = "Nombre de portes :";
            // 
            // CarLicense_label
            // 
            this.CarLicense_label.AutoSize = true;
            this.CarLicense_label.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarLicense_label.ForeColor = System.Drawing.Color.Orange;
            this.CarLicense_label.Location = new System.Drawing.Point(735, 226);
            this.CarLicense_label.Name = "CarLicense_label";
            this.CarLicense_label.Size = new System.Drawing.Size(171, 23);
            this.CarLicense_label.TabIndex = 116;
            this.CarLicense_label.Text = "Plaque de la voiture :";
            // 
            // CarName_label
            // 
            this.CarName_label.AutoSize = true;
            this.CarName_label.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarName_label.ForeColor = System.Drawing.Color.Orange;
            this.CarName_label.Location = new System.Drawing.Point(739, 173);
            this.CarName_label.Name = "CarName_label";
            this.CarName_label.Size = new System.Drawing.Size(156, 23);
            this.CarName_label.TabIndex = 115;
            this.CarName_label.Text = "Nom de la voiture :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(226, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 32);
            this.label1.TabIndex = 114;
            this.label1.Text = "Liste des voitures";
            // 
            // CreateCommand
            // 
            this.CreateCommand.AutoSize = true;
            this.CreateCommand.Font = new System.Drawing.Font("Sitka Text", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateCommand.ForeColor = System.Drawing.Color.Orange;
            this.CreateCommand.Location = new System.Drawing.Point(860, 110);
            this.CreateCommand.Name = "CreateCommand";
            this.CreateCommand.Size = new System.Drawing.Size(211, 32);
            this.CreateCommand.TabIndex = 113;
            this.CreateCommand.Text = "Ajouter une voiture";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(519, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 32);
            this.label5.TabIndex = 137;
            this.label5.Text = "Gestion des voitures";
            // 
            // FormCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1283, 806);
            this.Controls.Add(this.label5);
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
        private System.Windows.Forms.Label label5;
    }
}