namespace Cemidex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Aplicativo em Desenvolvimento. \n Fa�a login usando teste em usu�rio e senha" +
            "\nTroque o caminho do diretorio em Cemidex Context", "Aten��o", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void linkLabel1_LinkClicked(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicativo em Desenvolvimento.\n Fun��o Indispon�vel", "Aten��o", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == "teste" && txtUser.Text == "teste")
            {
                telaMenu telaMenu = new telaMenu();
                telaMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Senha e/ou usu�rio incorreto(s).\n Use teste", "Aten��o", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }


    }
}