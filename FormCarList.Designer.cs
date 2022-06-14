
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
            this.button2.BackColor = System.Drawing.Color.DarkOrange;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(499, 700);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(365, 55);
            this.button2.TabIndex = 99;
            this.button2.Text = "Quitter";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // searchBar_Car
            // 
            this.searchBar_Car.Location = new System.Drawing.Point(14, 105);
            this.searchBar_Car.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchBar_Car.Name = "searchBar_Car";
            this.searchBar_Car.Size = new System.Drawing.Size(313, 27);
            this.searchBar_Car.TabIndex = 98;
            // 
            // searchButton_car
            // 
            this.searchButton_car.BackColor = System.Drawing.Color.DarkOrange;
            this.searchButton_car.ForeColor = System.Drawing.SystemColors.Control;
            this.searchButton_car.Location = new System.Drawing.Point(350, 105);
            this.searchButton_car.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchButton_car.Name = "searchButton_car";
            this.searchButton_car.Size = new System.Drawing.Size(91, 31);
            this.searchButton_car.TabIndex = 97;
            this.searchButton_car.Text = "Rechercher";
            this.searchButton_car.UseVisualStyleBackColor = false;
            this.searchButton_car.Click += new System.EventHandler(this.searchButton_Car_Click);
            // 
            // searchBar_laabel
            // 
            this.searchBar_laabel.AutoSize = true;
            this.searchBar_laabel.BackColor = System.Drawing.Color.Wheat;
            this.searchBar_laabel.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBar_laabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.searchBar_laabel.Location = new System.Drawing.Point(62, 67);
            this.searchBar_laabel.Name = "searchBar_laabel";
            this.searchBar_laabel.Size = new System.Drawing.Size(237, 29);
            this.searchBar_laabel.TabIndex = 96;
            this.searchBar_laabel.Text = "Rechercher par plaque :";
            // 
            // lvListBikes
            // 
            this.lvListBikes.FullRowSelect = true;
            this.lvListBikes.GridLines = true;
            this.lvListBikes.HideSelection = false;
            this.lvListBikes.Location = new System.Drawing.Point(13, 144);
            this.lvListBikes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvListBikes.Name = "lvListBikes";
            this.lvListBikes.Size = new System.Drawing.Size(1378, 547);
            this.lvListBikes.TabIndex = 95;
            this.lvListBikes.UseCompatibleStateImageBehavior = false;
            this.lvListBikes.View = System.Windows.Forms.View.Details;
            // 
            // selectTextMenu
            // 
            this.selectTextMenu.AutoSize = true;
            this.selectTextMenu.Font = new System.Drawing.Font("Sitka Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTextMenu.ForeColor = System.Drawing.Color.Orange;
            this.selectTextMenu.Location = new System.Drawing.Point(499, 9);
            this.selectTextMenu.Name = "selectTextMenu";
            this.selectTextMenu.Size = new System.Drawing.Size(365, 58);
            this.selectTextMenu.TabIndex = 94;
            this.selectTextMenu.Text = "Liste des voitures ";
            this.selectTextMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1403, 761);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.searchBar_Car);
            this.Controls.Add(this.searchButton_car);
            this.Controls.Add(this.searchBar_laabel);
            this.Controls.Add(this.lvListBikes);
            this.Controls.Add(this.selectTextMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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