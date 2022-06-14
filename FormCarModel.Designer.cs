
namespace Car_Rental
{
    partial class FormCarModel
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
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lvCarModel = new System.Windows.Forms.ListView();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.NameCarModel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Wheat;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(542, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(444, 40);
            this.label5.TabIndex = 93;
            this.label5.Text = "Gestion des modèles de véhicule";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOrange;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(603, 671);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(339, 75);
            this.button2.TabIndex = 92;
            this.button2.Text = "Quitter";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lvCarModel
            // 
            this.lvCarModel.FullRowSelect = true;
            this.lvCarModel.GridLines = true;
            this.lvCarModel.HideSelection = false;
            this.lvCarModel.Location = new System.Drawing.Point(47, 176);
            this.lvCarModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvCarModel.Name = "lvCarModel";
            this.lvCarModel.Size = new System.Drawing.Size(542, 457);
            this.lvCarModel.TabIndex = 91;
            this.lvCarModel.UseCompatibleStateImageBehavior = false;
            this.lvCarModel.View = System.Windows.Forms.View.Details;
            this.lvCarModel.DoubleClick += new System.EventHandler(this.lvCarModel_DoubleClick);
            // 
            // button_Reset
            // 
            this.button_Reset.BackColor = System.Drawing.Color.DarkOrange;
            this.button_Reset.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Reset.Location = new System.Drawing.Point(986, 488);
            this.button_Reset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(225, 75);
            this.button_Reset.TabIndex = 90;
            this.button_Reset.Text = "Rafraîchir la page";
            this.button_Reset.UseVisualStyleBackColor = false;
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.Color.DarkOrange;
            this.button_Update.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Update.Location = new System.Drawing.Point(1117, 377);
            this.button_Update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(225, 75);
            this.button_Update.TabIndex = 88;
            this.button_Update.Text = "Modifier une marque";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(134, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 40);
            this.label1.TabIndex = 86;
            this.label1.Text = "Liste des marques de véhicule";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(872, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 35);
            this.label2.TabIndex = 85;
            this.label2.Text = "Nom de la marque";
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.DarkOrange;
            this.button_Add.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Add.Location = new System.Drawing.Point(847, 377);
            this.button_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(225, 75);
            this.button_Add.TabIndex = 84;
            this.button_Add.Text = "Ajouter une marque";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // NameCarModel
            // 
            this.NameCarModel.Location = new System.Drawing.Point(1117, 259);
            this.NameCarModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameCarModel.Multiline = true;
            this.NameCarModel.Name = "NameCarModel";
            this.NameCarModel.PlaceholderText = "Renseignez le nom du modèle";
            this.NameCarModel.Size = new System.Drawing.Size(196, 29);
            this.NameCarModel.TabIndex = 82;
            this.NameCarModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(986, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 40);
            this.label4.TabIndex = 81;
            this.label4.Text = "Ajout de marque";
            // 
            // FormCarModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1403, 761);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lvCarModel);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.NameCarModel);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCarModel";
            this.Text = "Gestionnaire des marques de voitures";
            this.Load += new System.EventHandler(this.FormCarModel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView lvCarModel;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox NameCarModel;
        private System.Windows.Forms.Label label4;
    }
}