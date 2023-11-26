using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaPagamento
{
    public partial class Tela_Login : Form
    {
        public Tela_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void UsertextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (user.Text == "admin" && pass.Text == "admin")
            {
                // Login bem-sucedido
                MostrarMensagemStatus($"Status do login: Concluído com sucesso para {user.Text}");

                // Oculta o formulário de login e exibe o formulário inicial
                this.Hide();
                Tela_Inicial formInicial = new Tela_Inicial();
                formInicial.ShowDialog();
            }
            else
            {
                // Login falhou
                MostrarMensagemStatus("Status do login: Falha. Nome de usuário ou senha incorretos.");
            }
        }

        // Método para exibir a mensagem de status usando MessageBox
        private void MostrarMensagemStatus(string mensagem)
        {
            MessageBox.Show(mensagem, "Mensagem de Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Fechar o aplicativo quando o botão de saída for clicado
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
