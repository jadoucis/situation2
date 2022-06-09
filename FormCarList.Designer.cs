
namespace Car_Rental
{
    partial class FormCarList
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
            this.button2 = new System.Windows.Forms.Button();
            this.searchBar_Car = new System.Windows.Forms.TextBox();
            this.searchButton_car = new System.Windows.Forms.Button();
            this.searchBar_laabel = new System.Windows.Forms.Label();
            this.lvListBikes = new System.Windows.Forms.ListView();
            this.selectTextMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(459, 525);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(297, 41);
            this.button2.TabIndex = 99;
            this.button2.Text = "Quitter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // searchBar_Car
            // 
            this.searchBar_Car.Location = new System.Drawing.Point(12, 79);
            this.searchBar_Car.Name = "searchBar_Car";
            this.searchBar_Car.Size = new System.Drawing.Size(274, 23);
            this.searchBar_Car.TabIndex = 98;
            // 
            // searchButton_car
            // 
            this.searchButton_car.Location = new System.Drawing.Point(306, 79);
            this.searchButton_car.Name = "searchButton_car";
            this.searchButton_car.Size = new System.Drawing.Size(80, 23);
            this.searchButton_car.TabIndex = 97;
            this.searchButton_car.Text = "Rechercher";
            this.searchButton_car.UseVisualStyleBackColor = true;
            this.searchButton_car.Click += new System.EventHandler(this.searchButton_Car_Click);
            // 
            // searchBar_laabel
            // 
            this.searchBar_laabel.AutoSize = true;
            this.searchBar_laabel.BackColor = System.Drawing.Color.DarkGray;
            this.searchBar_laabel.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBar_laabel.ForeColor = System.Drawing.Color.Orange;
            this.searchBar_laabel.Location = new System.Drawing.Point(54, 50);
            this.searchBar_laabel.Name = "searchBar_laabel";
            this.searchBar_laabel.Size = new System.Drawing.Size(191, 23);
            this.searchBar_laabel.TabIndex = 96;
            this.searchBar_laabel.Text = "Rechercher par plaque :";
            // 
            // lvListBikes
            // 
            this.lvListBikes.FullRowSelect = true;
            this.lvListBikes.GridLines = true;
            this.lvListBikes.HideSelection = false;
            this.lvListBikes.Location = new System.Drawing.Point(11, 108);
            this.lvListBikes.Name = "lvListBikes";
            this.lvListBikes.Size = new System.Drawing.Size(1206, 411);
            this.lvListBikes.TabIndex = 95;
            this.lvListBikes.UseCompatibleStateImageBehavior = false;
            this.lvListBikes.View = System.Windows.Forms.View.Details;
            // 
            // selectTextMenu
            // 
            this.selectTextMenu.AutoSize = true;
            this.selectTextMenu.Font = new System.Drawing.Font("Sitka Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTextMenu.ForeColor = System.Drawing.Color.Orange;
            this.selectTextMenu.Location = new System.Drawing.Point(295, 5);
            this.selectTextMenu.Name = "selectTextMenu";
            this.selectTextMenu.Size = new System.Drawing.Size(654, 47);
            this.selectTextMenu.TabIndex = 94;
            this.selectTextMenu.Text = "Liste des voitures dans la base de données";
            // 
            // FormCarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1228, 571);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.searchBar_Car);
            this.Controls.Add(this.searchButton_car);
            this.Controls.Add(this.searchBar_laabel);
            this.Controls.Add(this.lvListBikes);
            this.Controls.Add(this.selectTextMenu);
            this.Name = "FormCarList";
            this.Text = "Liste des voitures enregistrées en base de données";
            this.Load += new System.EventHandler(this.FormCarList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox searchBar_Car;
        private System.Windows.Forms.Button searchButton_car;
        private System.Windows.Forms.Label searchBar_laabel;
        private System.Windows.Forms.ListView lvListBikes;
        private System.Windows.Forms.Label selectTextMenu;
    }
}