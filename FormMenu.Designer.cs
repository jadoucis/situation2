
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
            this.SuspendLayout();
            // 
            // bienvenueTextMenu
            // 
            this.bienvenueTextMenu.Font = new System.Drawing.Font("Sitka Text", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bienvenueTextMenu.ForeColor = System.Drawing.Color.Orange;
            this.bienvenueTextMenu.Location = new System.Drawing.Point(365, 82);
            this.bienvenueTextMenu.Name = "bienvenueTextMenu";
            this.bienvenueTextMenu.Size = new System.Drawing.Size(581, 65);
            this.bienvenueTextMenu.TabIndex = 68;
            this.bienvenueTextMenu.Text = "Bienvenue sur le Menu Principal";
            // 
            // button_Rental
            // 
            this.button_Rental.Location = new System.Drawing.Point(128, 262);
            this.button_Rental.Name = "button_Rental";
            this.button_Rental.Size = new System.Drawing.Size(359, 121);
            this.button_Rental.TabIndex = 67;
            this.button_Rental.Text = "ACCEDER A LA PARTIE LOCATION";
            this.button_Rental.UseVisualStyleBackColor = true;
            this.button_Rental.Click += new System.EventHandler(this.button_Rental_Click);
            // 
            // button_Admin
            // 
            this.button_Admin.Location = new System.Drawing.Point(728, 262);
            this.button_Admin.Name = "button_Admin";
            this.button_Admin.Size = new System.Drawing.Size(359, 121);
            this.button_Admin.TabIndex = 66;
            this.button_Admin.Text = "ACCEDER A LA PARTIE ADMINISTRATION";
            this.button_Admin.UseVisualStyleBackColor = true;
            this.button_Admin.Click += new System.EventHandler(this.button_Admin_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1226, 569);
            this.Controls.Add(this.bienvenueTextMenu);
            this.Controls.Add(this.button_Rental);
            this.Controls.Add(this.button_Admin);
            this.Name = "FormMenu";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label bienvenueTextMenu;
        private System.Windows.Forms.Button button_Rental;
        private System.Windows.Forms.Button button_Admin;
    }
}