
namespace Car_Rental
{
    partial class FormCommandList
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
            this.searchBar_command = new System.Windows.Forms.TextBox();
            this.searchButton_Command = new System.Windows.Forms.Button();
            this.searchBar_laabel = new System.Windows.Forms.Label();
            this.lvListCommands = new System.Windows.Forms.ListView();
            this.selectTextMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(458, 523);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(297, 41);
            this.button2.TabIndex = 105;
            this.button2.Text = "Quitter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // searchBar_command
            // 
            this.searchBar_command.Location = new System.Drawing.Point(12, 77);
            this.searchBar_command.Name = "searchBar_command";
            this.searchBar_command.Size = new System.Drawing.Size(274, 23);
            this.searchBar_command.TabIndex = 104;
            // 
            // searchButton_Command
            // 
            this.searchButton_Command.Location = new System.Drawing.Point(303, 77);
            this.searchButton_Command.Name = "searchButton_Command";
            this.searchButton_Command.Size = new System.Drawing.Size(80, 23);
            this.searchButton_Command.TabIndex = 103;
            this.searchButton_Command.Text = "Rechercher";
            this.searchButton_Command.UseVisualStyleBackColor = true;
            this.searchButton_Command.Click += new System.EventHandler(this.searchButton_Command_Click);
            // 
            // searchBar_laabel
            // 
            this.searchBar_laabel.AutoSize = true;
            this.searchBar_laabel.BackColor = System.Drawing.Color.DarkGray;
            this.searchBar_laabel.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBar_laabel.ForeColor = System.Drawing.Color.Orange;
            this.searchBar_laabel.Location = new System.Drawing.Point(54, 48);
            this.searchBar_laabel.Name = "searchBar_laabel";
            this.searchBar_laabel.Size = new System.Drawing.Size(172, 23);
            this.searchBar_laabel.TabIndex = 102;
            this.searchBar_laabel.Text = "Rechercher par client";
            // 
            // lvListCommands
            // 
            this.lvListCommands.FullRowSelect = true;
            this.lvListCommands.GridLines = true;
            this.lvListCommands.HideSelection = false;
            this.lvListCommands.Location = new System.Drawing.Point(10, 106);
            this.lvListCommands.Name = "lvListCommands";
            this.lvListCommands.Size = new System.Drawing.Size(1206, 411);
            this.lvListCommands.TabIndex = 101;
            this.lvListCommands.UseCompatibleStateImageBehavior = false;
            this.lvListCommands.View = System.Windows.Forms.View.Details;
            // 
            // selectTextMenu
            // 
            this.selectTextMenu.AutoSize = true;
            this.selectTextMenu.Font = new System.Drawing.Font("Sitka Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTextMenu.ForeColor = System.Drawing.Color.Orange;
            this.selectTextMenu.Location = new System.Drawing.Point(253, 7);
            this.selectTextMenu.Name = "selectTextMenu";
            this.selectTextMenu.Size = new System.Drawing.Size(709, 47);
            this.selectTextMenu.TabIndex = 100;
            this.selectTextMenu.Text = "Liste des commandes dans la base de données";
            // 
            // FormCommandList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1227, 570);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.searchBar_command);
            this.Controls.Add(this.searchButton_Command);
            this.Controls.Add(this.searchBar_laabel);
            this.Controls.Add(this.lvListCommands);
            this.Controls.Add(this.selectTextMenu);
            this.Name = "FormCommandList";
            this.Text = "Liste des commandes enregistrées dans la base de données";
            this.Load += new System.EventHandler(this.FormCommandList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox searchBar_command;
        private System.Windows.Forms.Button searchButton_Command;
        private System.Windows.Forms.Label searchBar_laabel;
        private System.Windows.Forms.ListView lvListCommands;
        private System.Windows.Forms.Label selectTextMenu;
    }
}