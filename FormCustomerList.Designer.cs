
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
            this.button2.BackColor = System.Drawing.Color.DarkOrange;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(526, 700);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(336, 55);
            this.button2.TabIndex = 93;
            this.button2.Text = "Quitter";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // searchBar_customer
            // 
            this.searchBar_customer.Location = new System.Drawing.Point(11, 105);
            this.searchBar_customer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchBar_customer.Name = "searchBar_customer";
            this.searchBar_customer.Size = new System.Drawing.Size(313, 27);
            this.searchBar_customer.TabIndex = 92;
            // 
            // searchButton_customers
            // 
            this.searchButton_customers.BackColor = System.Drawing.Color.DarkOrange;
            this.searchButton_customers.ForeColor = System.Drawing.SystemColors.Control;
            this.searchButton_customers.Location = new System.Drawing.Point(349, 105);
            this.searchButton_customers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchButton_customers.Name = "searchButton_customers";
            this.searchButton_customers.Size = new System.Drawing.Size(91, 31);
            this.searchButton_customers.TabIndex = 91;
            this.searchButton_customers.Text = "Rechercher";
            this.searchButton_customers.UseVisualStyleBackColor = false;
            this.searchButton_customers.Click += new System.EventHandler(this.searchButton_customers_Click);
            // 
            // searchBar_laabel
            // 
            this.searchBar_laabel.AutoSize = true;
            this.searchBar_laabel.BackColor = System.Drawing.Color.Wheat;
            this.searchBar_laabel.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBar_laabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.searchBar_laabel.Location = new System.Drawing.Point(59, 67);
            this.searchBar_laabel.Name = "searchBar_laabel";
            this.searchBar_laabel.Size = new System.Drawing.Size(227, 29);
            this.searchBar_laabel.TabIndex = 90;
            this.searchBar_laabel.Text = "Rechercher par client :";
            // 
            // lvListCustomers
            // 
            this.lvListCustomers.FullRowSelect = true;
            this.lvListCustomers.GridLines = true;
            this.lvListCustomers.HideSelection = false;
            this.lvListCustomers.Location = new System.Drawing.Point(11, 144);
            this.lvListCustomers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvListCustomers.Name = "lvListCustomers";
            this.lvListCustomers.Size = new System.Drawing.Size(1378, 547);
            this.lvListCustomers.TabIndex = 89;
            this.lvListCustomers.UseCompatibleStateImageBehavior = false;
            this.lvListCustomers.View = System.Windows.Forms.View.Details;
            // 
            // selectTextMenu
            // 
            this.selectTextMenu.AutoSize = true;
            this.selectTextMenu.Font = new System.Drawing.Font("Sitka Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTextMenu.ForeColor = System.Drawing.Color.DarkOrange;
            this.selectTextMenu.Location = new System.Drawing.Point(526, 9);
            this.selectTextMenu.Name = "selectTextMenu";
            this.selectTextMenu.Size = new System.Drawing.Size(336, 58);
            this.selectTextMenu.TabIndex = 88;
            this.selectTextMenu.Text = "Liste des clients ";
            // 
            // FormCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1401, 761);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.searchBar_customer);
            this.Controls.Add(this.searchButton_customers);
            this.Controls.Add(this.searchBar_laabel);
            this.Controls.Add(this.lvListCustomers);
            this.Controls.Add(this.selectTextMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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