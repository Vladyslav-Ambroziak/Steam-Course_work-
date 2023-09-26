using LowCopySteam.View.Forms;
using LowCopySteam.View.UserControls;

namespace LowCopySteam
{
    public partial class Form1 : Form
    {
        StoreGame store = new StoreGame();
        public Form1()
        {
            LoginOrCreateAccount form2 = new LoginOrCreateAccount();
            form2.Show();

            InitializeComponent();



        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClickToButton(this.Shop_toolStripMenuItem);
            this.store.Visible = true;
            store.Location = new Point(0, this.menuStrip1.Height);
            this.Controls.Add(store);
        }

        private void lIBRARYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClickToButton(this.lIBRARYToolStripMenuItem);
            if (this.store.Visible)
                this.store.Visible = false;
        }

        private void pROFILEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClickToButton(this.pROFILEToolStripMenuItem);
        }
        private void ClickToButton(ToolStripMenuItem button)
        {
            if (this.Shop_toolStripMenuItem.ForeColor == Color.FromArgb(26, 158, 253))
            {
                this.Shop_toolStripMenuItem.ForeColor = Color.FromArgb(253, 253, 253);
                this.Shop_toolStripMenuItem.Font = new Font(this.Shop_toolStripMenuItem.Font, FontStyle.Bold);
            }
            if (this.lIBRARYToolStripMenuItem.ForeColor == Color.FromArgb(26, 158, 253))
            {
                this.lIBRARYToolStripMenuItem.ForeColor = Color.FromArgb(253, 253, 253);
                this.lIBRARYToolStripMenuItem.Font = new Font(this.lIBRARYToolStripMenuItem.Font, FontStyle.Bold);
            }
            if (this.pROFILEToolStripMenuItem.ForeColor == Color.FromArgb(26, 158, 253))
            {
                this.pROFILEToolStripMenuItem.ForeColor = Color.FromArgb(253, 253, 253);
                this.pROFILEToolStripMenuItem.Font = new Font(this.pROFILEToolStripMenuItem.Font, FontStyle.Bold);
            }

            button.ForeColor = Color.FromArgb(26, 158, 253);
            button.Font = new Font(button.Font.FontFamily, button.Font.Size, FontStyle.Underline | FontStyle.Bold);
        }
    }
}