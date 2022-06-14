
namespace Car_Rental
{
    partial class FormAdminManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminManager));
            this.selectTextMenu = new System.Windows.Forms.Label();
            this.carLists = new System.Windows.Forms.Button();
            this.button_CommandList = new System.Windows.Forms.Button();
            this.button_CustomerList = new System.Windows.Forms.Button();
            this.button_AdminAccount = new System.Windows.Forms.Button();
            this.button_quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectTextMenu
            // 
            this.selectTextMenu.BackColor = System.Drawing.Color.Wheat;
            resources.ApplyResources(this.selectTextMenu, "selectTextMenu");
            this.selectTextMenu.ForeColor = System.Drawing.Color.DarkOrange;
            this.selectTextMenu.Name = "selectTextMenu";
            this.selectTextMenu.Click += new System.EventHandler(this.selectTextMenu_Click);
            // 
            // carLists
            // 
            this.carLists.BackColor = System.Drawing.Color.DarkOrange;
            this.carLists.ForeColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.carLists, "carLists");
            this.carLists.Name = "carLists";
            this.carLists.UseVisualStyleBackColor = false;
            this.carLists.Click += new System.EventHandler(this.carLists_Click);
            // 
            // button_CommandList
            // 
            this.button_CommandList.BackColor = System.Drawing.Color.DarkOrange;
            this.button_CommandList.ForeColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.button_CommandList, "button_CommandList");
            this.button_CommandList.Name = "button_CommandList";
            this.button_CommandList.UseVisualStyleBackColor = false;
            this.button_CommandList.Click += new System.EventHandler(this.button_CommandList_Click);
            // 
            // button_CustomerList
            // 
            this.button_CustomerList.BackColor = System.Drawing.Color.DarkOrange;
            this.button_CustomerList.ForeColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.button_CustomerList, "button_CustomerList");
            this.button_CustomerList.Name = "button_CustomerList";
            this.button_CustomerList.UseVisualStyleBackColor = false;
            this.button_CustomerList.Click += new System.EventHandler(this.button_CustomerList_Click);
            // 
            // button_AdminAccount
            // 
            this.button_AdminAccount.BackColor = System.Drawing.Color.DarkOrange;
            this.button_AdminAccount.ForeColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.button_AdminAccount, "button_AdminAccount");
            this.button_AdminAccount.Name = "button_AdminAccount";
            this.button_AdminAccount.UseVisualStyleBackColor = false;
            this.button_AdminAccount.Click += new System.EventHandler(this.button_AdminAccount_Click);
            // 
            // button_quit
            // 
            this.button_quit.BackColor = System.Drawing.Color.DarkOrange;
            this.button_quit.ForeColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.button_quit, "button_quit");
            this.button_quit.Name = "button_quit";
            this.button_quit.UseVisualStyleBackColor = false;
            this.button_quit.Click += new System.EventHandler(this.button_quit_Click);
            // 
            // FormAdminManager
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.Controls.Add(this.button_quit);
            this.Controls.Add(this.selectTextMenu);
            this.Controls.Add(this.carLists);
            this.Controls.Add(this.button_CommandList);
            this.Controls.Add(this.button_CustomerList);
            this.Controls.Add(this.button_AdminAccount);
            this.Name = "FormAdminManager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label selectTextMenu;
        private System.Windows.Forms.Button carLists;
        private System.Windows.Forms.Button button_CommandList;
        private System.Windows.Forms.Button button_CustomerList;
        private System.Windows.Forms.Button button_AdminAccount;
        private System.Windows.Forms.Button button_quit;
    }
}