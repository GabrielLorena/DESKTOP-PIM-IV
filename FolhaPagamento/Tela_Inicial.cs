using System;
using System.Windows.Forms;

namespace FolhaPagamento
{
    public partial class Tela_Inicial : Form
    {
        public Tela_Inicial()
        {
            InitializeComponent();
        }

        private void Tela_Inicial_Load(object sender, EventArgs e)
        {
            // Evento de carregamento do formulário
        }
        private void label1_Click(object sender, EventArgs e)
        {
            // Código associado ao clique na label1
        }

        private void btnAcessarCadastro_Click_1(object sender, EventArgs e)
        {
            // Oculta a tela inicial
            this.Hide();

            // Abre o formulário de cadastro de funcionários
            iStorm formCadastro = new iStorm();
            formCadastro.FormClosed += (s, args) => this.Show(); // Exibe a tela inicial quando o formulário de cadastro é fechado
            formCadastro.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Exibe uma mensagem de confirmação
            DialogResult result = MessageBox.Show("Tem certeza de que deseja fazer logout?", "Confirmação de Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Se o usuário confirmar o logout, fecha a tela atual e exibe a tela de login
            if (result == DialogResult.Yes)
            {
                this.Close(); // Fecha a tela atual
                Tela_Login formLogin = new Tela_Login();
                formLogin.Show(); // Exibe a tela de login
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Oculta a tela inicial
            this.Hide();

            // Abre o formulário de cadastro de funcionários
            Visualizar_Funcionarios1 formVisualizar = new Visualizar_Funcionarios1();
            formVisualizar.FormClosed += (s, args) => this.Show(); // Exibe a tela inicial quando o formulário de cadastro é fechado
            formVisualizar.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Oculta a tela inicial
            this.Hide();

            // Abre o formulário de cadastro de funcionários
            Visualizar_FolhaPagamento1 formVisualizar2 = new Visualizar_FolhaPagamento1();
            formVisualizar2.FormClosed += (s, args) => this.Show(); // Exibe a tela inicial quando o formulário de cadastro é fechado
            formVisualizar2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Oculta a tela inicial
            this.Hide();

            // Abre o formulário de cadastro de funcionários
            Cadastro_FolhaPagamento formFolhaPagamento = new Cadastro_FolhaPagamento();
            formFolhaPagamento.FormClosed += (s, args) => this.Show(); // Exibe a tela inicial quando o formulário de cadastro é fechado
            formFolhaPagamento.ShowDialog();

        }
    }
}
