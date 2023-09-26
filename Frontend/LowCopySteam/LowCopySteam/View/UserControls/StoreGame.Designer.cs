namespace LowCopySteam.View.UserControls
{
    partial class StoreGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreGame));
            panel1 = new Panel();
            button2 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 55, 124);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(79, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(795, 31);
            panel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(111, 140, 0);
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(111, 140, 0);
            button2.Location = new Point(633, 4);
            button2.Name = "button2";
            button2.Size = new Size(159, 23);
            button2.TabIndex = 4;
            button2.Text = "Cart(0)";
            button2.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(49, 98, 130);
            comboBox1.FlatStyle = FlatStyle.Popup;
            comboBox1.ForeColor = Color.FromArgb(253, 253, 253);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "All" });
            comboBox1.Location = new Point(441, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(131, 23);
            comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(253, 253, 253);
            label1.Location = new Point(384, 4);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 2;
            label1.Text = "Genre:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(83, 156, 198);
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(305, 4);
            button1.Name = "button1";
            button1.Size = new Size(23, 23);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(49, 98, 130);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.ForeColor = Color.FromArgb(253, 253, 253);
            textBox1.Location = new Point(4, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(304, 23);
            textBox1.TabIndex = 0;
            // 
            // StoreGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 40, 56);
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(panel1);
            Name = "StoreGame";
            Size = new Size(965, 500);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
        private ComboBox comboBox1;
    }
}
