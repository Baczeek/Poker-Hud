using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hud
{
    public partial class PlayerInfoForm : Form
    {
        public TextBox playerInfoTextBox;
        public PlayerInfoForm(int x, int y)
        {
            this.Location = new Point(x, y);
            InitializeComponent();
        }

        public void changeTextBox(TextBox textBox)
        {
            playerInfoTextBox = textBox;
            playerInfoTextBox.Location = new Point(0, 0);
        }
    }
}
