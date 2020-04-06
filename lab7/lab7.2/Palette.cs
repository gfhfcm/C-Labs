using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7._2
{
    public partial class Palette : Form
    {
        public Palette()
        {
            InitializeComponent();
            NewColor();
        }
        private void NewColor()
        {
            ColorPanel.BackColor = Color.FromArgb(tb_red.Value, tb_green.Value, tb_blue.Value);
            Clipboard.Clear();
            Clipboard.SetText($"#{tb_red.Value:X}{tb_green.Value:X}{tb_blue.Value:X}");
            toolTip.SetToolTip(ColorPanel, Clipboard.GetText());
        }

        private void color_scroll(object sender, EventArgs e)
        {
            NewColor();
        }

    }
}
