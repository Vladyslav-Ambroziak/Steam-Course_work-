namespace LowCopySteam.View.UserControls
{
    partial class MiniIconGame
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiniIconGame));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(303, 149);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(253, 253, 253);
            label1.Location = new Point(3, 155);
            label1.Name = "label1";
            label1.Size = new Size(242, 17);
            label1.TabIndex = 1;
            label1.Text = "Wolfenstein II: The New Colossus";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(39, 65, 88);
            label2.ForeColor = Color.FromArgb(253, 253, 253);
            label2.Location = new Point(263, 155);
            label2.Name = "label2";
            label2.Padding = new Padding(4, 2, 4, 2);
            label2.Size = new Size(33, 19);
            label2.TabIndex = 2;
            label2.Text = "70$";
            // 
            // MiniIconGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(63, 119, 151);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            Name = "MiniIconGame";
            Size = new Size(303, 180);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
    }
}
