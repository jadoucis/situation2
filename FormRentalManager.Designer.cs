
namespace Car_Rental
{
    partial class FormRentalManager
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
            this.selectTextRent = new System.Windows.Forms.Label();
            this.button_AddCarModel = new System.Windows.Forms.Button();
            this.button_AddCommand = new System.Windows.Forms.Button();
            this.button_AddConsumer = new System.Windows.Forms.Button();
            this.button_CarStock = new System.Windows.Forms.Button();
            this.button_quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectTextRent
            // 
            this.selectTextRent.Font = new System.Drawing.Font("Sitka Text", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTextRent.ForeColor = System.Drawing.Color.DarkOrange;
            this.selectTextRent.Location = new System.Drawing.Point(471, 59);
            this.selectTextRent.Name = "selectTextRent";
            this.selectTextRent.Size = new System.Drawing.Size(449, 89);
            this.selectTextRent.TabIndex = 71;
            this.selectTextRent.Text = "Sélectionnez un espace";
            this.selectTextRent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_AddCarModel
            // 
            this.button_AddCarModel.BackColor = System.Drawing.Color.DarkOrange;
            this.button_AddCarModel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_AddCarModel.ForeColor = System.Drawing.SystemColors.Control;
            this.button_AddCarModel.Location = new System.Drawing.Point(471, 184);
            this.button_AddCarModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_AddCarModel.Name = "button_AddCarModel";
            this.button_AddCarModel.Size = new System.Drawing.Size(449, 81);
            this.button_AddCarModel.TabIndex = 70;
            this.button_AddCarModel.Text = "GERER LES MARQUES DE VOITURES";
            this.button_AddCarModel.UseVisualStyleBackColor = false;
            this.button_AddCarModel.Click += new System.EventHandler(this.button_AddCarModel_Click);
            // 
            // button_AddCommand
            // 
            this.button_AddCommand.BackColor = System.Drawing.Color.DarkOrange;
            this.button_AddCommand.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_AddCommand.ForeColor = System.Drawing.SystemColors.Control;
            this.button_AddCommand.Location = new System.Drawing.Point(471, 524);
            this.button_AddCommand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_AddCommand.Name = "button_AddCommand";
            this.button_AddCommand.Size = new System.Drawing.Size(449, 81);
            this.button_AddCommand.TabIndex = 69;
            this.button_AddCommand.Text = "GERER LES COMMANDES";
            this.button_AddCommand.UseVisualStyleBackColor = false;
            this.button_AddCommand.Click += new System.EventHandler(this.button_AddCommand_Click);
            // 
            // button_AddConsumer
            // 
            this.button_AddConsumer.BackColor = System.Drawing.Color.DarkOrange;
            this.button_AddConsumer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_AddConsumer.ForeColor = System.Drawing.SystemColors.Control;
            this.button_AddConsumer.Location = new System.Drawing.Point(471, 415);
            this.button_AddConsumer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_AddConsumer.Name = "button_AddConsumer";
            this.button_AddConsumer.Size = new System.Drawing.Size(449, 81);
            this.button_AddConsumer.TabIndex = 68;
            this.button_AddConsumer.Text = "GERER LES CLIENTS";
            this.button_AddConsumer.UseVisualStyleBackColor = false;
            this.button_AddConsumer.Click += new System.EventHandler(this.button_AddConsumer_Click);
            // 
            // button_CarStock
            // 
            this.button_CarStock.BackColor = System.Drawing.Color.DarkOrange;
            this.button_CarStock.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_CarStock.ForeColor = System.Drawing.SystemColors.Control;
            this.button_CarStock.Location = new System.Drawing.Point(471, 300);
            this.button_CarStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_CarStock.Name = "button_CarStock";
            this.button_CarStock.Size = new System.Drawing.Size(449, 81);
            this.button_CarStock.TabIndex = 67;
            this.button_CarStock.Text = "GERER LE STOCK DE VOITURES";
            this.button_CarStock.UseVisualStyleBackColor = false;
            this.button_CarStock.Click += new System.EventHandler(this.button_CarStock_Click);
            // 
            // button_quit
            // 
            this.button_quit.BackColor = System.Drawing.Color.DarkOrange;
            this.button_quit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_quit.ForeColor = System.Drawing.SystemColors.Control;
            this.button_quit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_quit.Location = new System.Drawing.Point(471, 644);
            this.button_quit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_quit.Name = "button_quit";
            this.button_quit.Size = new System.Drawing.Size(449, 81);
            this.button_quit.TabIndex = 74;
            this.button_quit.Text = "SORTIR DU MENU";
            this.button_quit.UseVisualStyleBackColor = false;
            this.button_quit.Click += new System.EventHandler(this.button_quit_Click);
            // 
            // FormRentalManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1402, 761);
            this.Controls.Add(this.button_quit);
            this.Controls.Add(this.selectTextRent);
            this.Controls.Add(this.button_AddCarModel);
            this.Controls.Add(this.button_AddCommand);
            this.Controls.Add(this.button_AddConsumer);
            this.Controls.Add(this.button_CarStock);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormRentalManager";
            this.Text = "Menu location";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label selectTextRent;
        private System.Windows.Forms.Button button_AddCarModel;
        private System.Windows.Forms.Button button_AddCommand;
        private System.Windows.Forms.Button button_AddConsumer;
        private System.Windows.Forms.Button button_CarStock;
        private System.Windows.Forms.Button button_quit;
    }
}