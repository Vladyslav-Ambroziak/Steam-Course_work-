namespace LowCopySteam
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            Shop_toolStripMenuItem = new ToolStripMenuItem();
            lIBRARYToolStripMenuItem = new ToolStripMenuItem();
            pROFILEToolStripMenuItem = new ToolStripMenuItem();
            fDFToolStripMenuItem = new ToolStripMenuItem();
            logOutOfAccountToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(23, 29, 37);
            menuStrip1.Items.AddRange(new ToolStripItem[] { Shop_toolStripMenuItem, lIBRARYToolStripMenuItem, pROFILEToolStripMenuItem, fDFToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 5, 0, 5);
            menuStrip1.Size = new Size(984, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // Shop_toolStripMenuItem
            // 
            Shop_toolStripMenuItem.Font = new Font("Tahoma", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            Shop_toolStripMenuItem.ForeColor = Color.FromArgb(253, 253, 253);
            Shop_toolStripMenuItem.Name = "Shop_toolStripMenuItem";
            Shop_toolStripMenuItem.Size = new Size(78, 25);
            Shop_toolStripMenuItem.Text = "STORE";
            Shop_toolStripMenuItem.Click += toolStripMenuItem1_Click;
            // 
            // lIBRARYToolStripMenuItem
            // 
            lIBRARYToolStripMenuItem.Font = new Font("Tahoma", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            lIBRARYToolStripMenuItem.ForeColor = Color.FromArgb(253, 253, 253);
            lIBRARYToolStripMenuItem.Name = "lIBRARYToolStripMenuItem";
            lIBRARYToolStripMenuItem.Size = new Size(99, 25);
            lIBRARYToolStripMenuItem.Text = "LIBRARY";
            lIBRARYToolStripMenuItem.Click += lIBRARYToolStripMenuItem_Click;
            // 
            // pROFILEToolStripMenuItem
            // 
            pROFILEToolStripMenuItem.Font = new Font("Tahoma", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            pROFILEToolStripMenuItem.ForeColor = Color.FromArgb(253, 253, 253);
            pROFILEToolStripMenuItem.Name = "pROFILEToolStripMenuItem";
            pROFILEToolStripMenuItem.Size = new Size(96, 25);
            pROFILEToolStripMenuItem.Text = "PROFILE";
            pROFILEToolStripMenuItem.Click += pROFILEToolStripMenuItem_Click;
            // 
            // fDFToolStripMenuItem
            // 
            fDFToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            fDFToolStripMenuItem.BackColor = Color.FromArgb(39, 45, 55);
            fDFToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logOutOfAccountToolStripMenuItem });
            fDFToolStripMenuItem.ForeColor = Color.FromArgb(150, 150, 150);
            fDFToolStripMenuItem.Image = (Image)resources.GetObject("fDFToolStripMenuItem.Image");
            fDFToolStripMenuItem.Margin = new Padding(0, 0, 5, 0);
            fDFToolStripMenuItem.Name = "fDFToolStripMenuItem";
            fDFToolStripMenuItem.Size = new Size(70, 25);
            fDFToolStripMenuItem.Text = "Ержан";
            // 
            // logOutOfAccountToolStripMenuItem
            // 
            logOutOfAccountToolStripMenuItem.BackColor = Color.FromArgb(61, 68, 80);
            logOutOfAccountToolStripMenuItem.ForeColor = Color.FromArgb(220, 222, 223);
            logOutOfAccountToolStripMenuItem.Name = "logOutOfAccountToolStripMenuItem";
            logOutOfAccountToolStripMenuItem.Size = new Size(180, 22);
            logOutOfAccountToolStripMenuItem.Text = "Log out of account";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(27, 40, 56);
            ClientSize = new Size(984, 511);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Steam";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem Shop_toolStripMenuItem;
        private ToolStripMenuItem lIBRARYToolStripMenuItem;
        private ToolStripMenuItem pROFILEToolStripMenuItem;
        private ToolStripMenuItem fDFToolStripMenuItem;
        private ToolStripMenuItem logOutOfAccountToolStripMenuItem;
    }
}