using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cemidex
{
    public partial class telaMenu : Form
    {
        public telaMenu()
        {
            InitializeComponent();
        }

        private void telaMenu_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void telaMenu_MouseHover_1(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            this.BackColor = Color.White;
            this.ForeColor = Color.Teal;
        }
    }
}
