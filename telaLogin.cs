namespace Cemidex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Aplicativo em Desenvolvimento. \n Faça login usando teste em usuário e senha" +
            "\nTroque o caminho do diretorio em Cemidex Context", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void linkLabel1_LinkClicked(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicativo em Desenvolvimento.\n Função Indisponível", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                MessageBox.Show("Senha e/ou usuário incorreto(s).\n Use teste", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }


    }
}