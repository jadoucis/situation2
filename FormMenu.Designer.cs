
namespace Car_Rental
{
    partial class FormMenu
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
            this.bienvenueTextMenu = new System.Windows.Forms.Label();
            this.button_Rental = new System.Windows.Forms.Button();
            this.button_Admin = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bienvenueTextMenu
            // 
            this.bienvenueTextMenu.BackColor = System.Drawing.Color.Wheat;
            this.bienvenueTextMenu.Font = new System.Drawing.Font("Sitka Text", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bienvenueTextMenu.ForeColor = System.Drawing.Color.DarkOrange;
            this.bienvenueTextMenu.Location = new System.Drawing.Point(-3, 60);
            this.bienvenueTextMenu.Name = "bienvenueTextMenu";
            this.bienvenueTextMenu.Size = new System.Drawing.Size(1405, 87);
            this.bienvenueTextMenu.TabIndex = 68;
            this.bienvenueTextMenu.Text = "Bienvenue sur le Menu Principal";
            this.bienvenueTextMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_Rental
            // 
            this.button_Rental.BackColor = System.Drawing.Color.DarkOrange;
            this.button_Rental.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Rental.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Rental.Location = new System.Drawing.Point(146, 294);
            this.button_Rental.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Rental.Name = "button_Rental";
            this.button_Rental.Size = new System.Drawing.Size(410, 161);
            this.button_Rental.TabIndex = 67;
            this.button_Rental.Text = "ESPACE LOCATION";
            this.button_Rental.UseVisualStyleBackColor = false;
            this.button_Rental.Click += new System.EventHandler(this.button_Rental_Click);
            // 
            // button_Admin
            // 
            this.button_Admin.BackColor = System.Drawing.Color.DarkOrange;
            this.button_Admin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Admin.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Admin.Location = new System.Drawing.Point(832, 294);
            this.button_Admin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Admin.Name = "button_Admin";
            this.button_Admin.Size = new System.Drawing.Size(410, 161);
            this.button_Admin.TabIndex = 66;
            this.button_Admin.Text = "ESPACE ADMINISTRATEUR";
            this.button_Admin.UseVisualStyleBackColor = false;
            this.button_Admin.Click += new System.EventHandler(this.button_Admin_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.DarkOrange;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.closeButton.Location = new System.Drawing.Point(568, 587);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(251, 104);
            this.closeButton.TabIndex = 69;
            this.closeButton.Text = "QUITTER";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1401, 759);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.bienvenueTextMenu);
            this.Controls.Add(this.button_Rental);
            this.Controls.Add(this.button_Admin);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMenu";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label bienvenueTextMenu;
        private System.Windows.Forms.Button button_Rental;
        private System.Windows.Forms.Button button_Admin;
        private System.Windows.Forms.Button closeButton;
    }
}