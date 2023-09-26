using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LowCopySteam.View.UserControls
{
    public partial class StoreGame : UserControl
    {
        public int x = 10;
        public int y = 19;
        public StoreGame()
        {
            InitializeComponent();
            y += panel1.Height + 19;
            for (int i = 0; i < 20; i++)
            {

                MiniIconGame game = new MiniIconGame();
                game.Location = new Point(x, y);
                x += game.Width + 10;
                if (x + game.Width >= this.Width)
                {
                    y += game.Height + 10;
                    this.Height += game.Height;
                    x = 10;
                }
                this.Controls.Add(game);
            }
        }
    }
}
