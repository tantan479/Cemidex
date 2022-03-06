using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cemidex;

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
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em desenvolvimento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            crudCemidex crudCemidex = new crudCemidex();
            crudCemidex.ShowDialog();
        }

        private void labelEncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
