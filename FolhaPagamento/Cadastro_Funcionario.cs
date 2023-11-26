using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaPagamento
{
    public partial class iStorm : Form
    {
        private const string apiUrl = "https://pimbackend.onrender.com/funcionarios"; // URL da sua API

        public iStorm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private async void BtnEnviar_Click(object sender, EventArgs e)
        {

        }

        private void LimparCampos()
        {
            // Limpar os campos do formul�rio ap�s o cadastro
            txtNome.Text = string.Empty;
            txtCPF.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtSalario.Text = string.Empty;
            txtDataAdmissao.Text = string.Empty;
            txtDepartamento.Text = string.Empty;
            txtDataNascimento.Text = string.Empty;
            txtCargo.Text = string.Empty;
            // Limpar outros campos conforme necess�rio
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private async void btnEnviar_Click_Click(object sender, EventArgs e)
        {
            int cdDepartamento = 1;
            switch (txtDepartamento.Text)
            {
                case "Operacional":
                    cdDepartamento = 1;
                    break;
                case "Gestao":
                    cdDepartamento = 2;
                    break;
                case "Administrativo":
                    cdDepartamento = 3;
                    break;
                case "RH":
                    cdDepartamento = 4;
                    break;
            }
            // Criar objeto Funcionario com base nos dados do formul�rio
            var novoFuncionario = new
            {
                nome = txtNome.Text,
                cpf = txtCPF.Text,
                telefone = txtTelefone.Text,
                endereco = txtEndereco.Text,
                salario = Convert.ToDecimal(txtSalario.Text),
                dtAdmissao = Convert.ToDateTime(txtDataAdmissao.Text),
                departamento = cdDepartamento,
                dataNascimento = Convert.ToDateTime(txtDataNascimento.Text),
                cargo = txtCargo.Text
                // Adicione outros campos conforme necess�rio
            };

            // Converter o objeto Funcionario para JSON
            var jsonFuncionario = Newtonsoft.Json.JsonConvert.SerializeObject(novoFuncionario);

            // Enviar a solicita��o POST para a API
            using (var httpClient = new HttpClient())
            {
                var content = new StringContent(jsonFuncionario, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync(apiUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Funcion�rio cadastrado com sucesso!");
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar o funcion�rio.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Fecha todas as inst�ncias da tela atual
            foreach (Form form in Application.OpenForms)
            {
                if (form is iStorm)
                {
                    form.Close();
                    break; // Sair do loop depois de fechar a primeira inst�ncia (se houver mais de uma)
                }
            }

            // Verifica se a tela inicial j� est� aberta antes de cri�-la novamente
            Tela_Inicial formLogin = Application.OpenForms.OfType<Tela_Inicial>().FirstOrDefault();

            if (formLogin == null)
            {
                // Se n�o estiver aberta, cria uma nova inst�ncia e a exibe
                formLogin = new Tela_Inicial();
                formLogin.Show();
            }
            else
            {
                // Se j� estiver aberta, traz para a frente
                formLogin.BringToFront();
            }
        }
    }
}
