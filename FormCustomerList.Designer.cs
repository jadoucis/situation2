
namespace Car_Rental
{
    partial class FormCustomerList
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
            this.searchBar_customer = new System.Windows.Forms.TextBox();
            this.searchButton_customers = new System.Windows.Forms.Button();
            this.searchBar_laabel = new System.Windows.Forms.Label();
            this.lvListCustomers = new System.Windows.Forms.ListView();
            this.selectTextMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(458, 525);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(297, 41);
            this.button2.TabIndex = 93;
            this.button2.Text = "Quitter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // searchBar_customer
            // 
            this.searchBar_customer.Location = new System.Drawing.Point(10, 79);
            this.searchBar_customer.Name = "searchBar_customer";
            this.searchBar_customer.Size = new System.Drawing.Size(274, 23);
            this.searchBar_customer.TabIndex = 92;
            // 
            // searchButton_customers
            // 
            this.searchButton_customers.Location = new System.Drawing.Point(305, 79);
            this.searchButton_customers.Name = "searchButton_customers";
            this.searchButton_customers.Size = new System.Drawing.Size(80, 23);
            this.searchButton_customers.TabIndex = 91;
            this.searchButton_customers.Text = "Rechercher";
            this.searchButton_customers.UseVisualStyleBackColor = true;
            this.searchButton_customers.Click += new System.EventHandler(this.searchButton_customers_Click);
            // 
            // searchBar_laabel
            // 
            this.searchBar_laabel.AutoSize = true;
            this.searchBar_laabel.BackColor = System.Drawing.Color.DarkGray;
            this.searchBar_laabel.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBar_laabel.ForeColor = System.Drawing.Color.Orange;
            this.searchBar_laabel.Location = new System.Drawing.Point(52, 50);
            this.searchBar_laabel.Name = "searchBar_laabel";
            this.searchBar_laabel.Size = new System.Drawing.Size(183, 23);
            this.searchBar_laabel.TabIndex = 90;
            this.searchBar_laabel.Text = "Rechercher par client :";
            // 
            // lvListCustomers
            // 
            this.lvListCustomers.FullRowSelect = true;
            this.lvListCustomers.GridLines = true;
            this.lvListCustomers.HideSelection = false;
            this.lvListCustomers.Location = new System.Drawing.Point(10, 108);
            this.lvListCustomers.Name = "lvListCustomers";
            this.lvListCustomers.Size = new System.Drawing.Size(1206, 411);
            this.lvListCustomers.TabIndex = 89;
            this.lvListCustomers.UseCompatibleStateImageBehavior = false;
            this.lvListCustomers.View = System.Windows.Forms.View.Details;
            // 
            // selectTextMenu
            // 
            this.selectTextMenu.AutoSize = true;
            this.selectTextMenu.Font = new System.Drawing.Font("Sitka Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTextMenu.ForeColor = System.Drawing.Color.Orange;
            this.selectTextMenu.Location = new System.Drawing.Point(294, 5);
            this.selectTextMenu.Name = "selectTextMenu";
            this.selectTextMenu.Size = new System.Drawing.Size(629, 47);
            this.selectTextMenu.TabIndex = 88;
            this.selectTextMenu.Text = "Liste des clients dans la base de données";
            // 
            // FormCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1226, 571);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.searchBar_customer);
            this.Controls.Add(this.searchButton_customers);
            this.Controls.Add(this.searchBar_laabel);
            this.Controls.Add(this.lvListCustomers);
            this.Controls.Add(this.selectTextMenu);
            this.Name = "FormCustomerList";
            this.Text = "Liste des clients enregistrés en base de données";
            this.Load += new System.EventHandler(this.FormCustomerList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox searchBar_customer;
        private System.Windows.Forms.Button searchButton_customers;
        private System.Windows.Forms.Label searchBar_laabel;
        private System.Windows.Forms.ListView lvListCustomers;
        private System.Windows.Forms.Label selectTextMenu;
    }
}