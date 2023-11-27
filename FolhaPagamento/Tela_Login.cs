﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.Json;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using Newtonsoft.Json;

namespace FolhaPagamento
{
    public partial class Tela_Login : Form
    {
        private const string apiUrl = "https://pimbackend.onrender.com/auth/login"; // Substitua pela URL da sua API
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
        private void LimparCampos()
        {
            // Limpar os campos do formulário após o cadastro
            txtUser.Text = string.Empty;
            txtPass.Text = string.Empty;

            // Limpar outros campos conforme necessário
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            var dados = new
            {
                email = txtUser.Text,
                senha = txtPass.Text,
            };
            var dadosJson = Newtonsoft.Json.JsonConvert.SerializeObject(dados);

            // Enviar a solicitação POST para a API
            using (var httpClient = new HttpClient())
            {
                var content = new StringContent(dadosJson, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync(apiUrl, content);


                // response.IsSuccessStatusCode
                if (response.IsSuccessStatusCode)
                {
                    var respostaConteudo = await response.Content.ReadAsStringAsync();
                    dynamic json = JsonConvert.DeserializeObject(respostaConteudo);

                    // Supondo que 'result' contenha a resposta do servidor
                    // string tipoUsuario = await response.Content.tipo;


                    if (json.tipo == 2) 
                    {
                        // Login bem-sucedido
                        MostrarMensagemStatus("Status do login: Sucesso.");


                        //Oculta o formulário de login e exibe o formulário inicial
                        this.Hide();
                        Tela_Inicial formInicial = new Tela_Inicial();
                        formInicial.ShowDialog();
                    }
                    else
                    {
                        // Login falhou
                        MostrarMensagemStatus("Status do login: Falha. Apenas gerentes de departamento podem acessar!.");
                    }
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar o funcionário testw.");
                }
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
