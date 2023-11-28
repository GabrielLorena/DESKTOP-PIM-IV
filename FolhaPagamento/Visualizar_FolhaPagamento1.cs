using Newtonsoft.Json; // Biblioteca para trabalhar com JSON
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Linq;
using System.Windows.Forms;

namespace FolhaPagamento
{
    public partial class Visualizar_FolhaPagamento1 : Form
    {
        private const string apiUrl = "https://pimbackend.onrender.com/folhas_pagamento/"; // URL da API
        private List<SeuObjeto> dadosOriginais; // Lista para armazenar os dados originais

        public Visualizar_FolhaPagamento1()
        {
            InitializeComponent();
            CarregarDadosDaAPI(); // Ao criar a instância do formulário, carrega os dados da API
        }

        // Método para carregar os dados da API de forma assíncrona
        private async void CarregarDadosDaAPI()
        {
            try
            {
                using (HttpClient client = new HttpClient()) // Cliente para fazer requisições HTTP
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl); // Faz a requisição GET para a API

                    if (response.IsSuccessStatusCode) // Se a requisição foi bem-sucedida
                    {
                        string json = await response.Content.ReadAsStringAsync(); // Lê o conteúdo da resposta como uma string JSON
                        dadosOriginais = JsonConvert.DeserializeObject<List<SeuObjeto>>(json); // Converte o JSON para uma lista de objetos

                        // Popula o DataGridView com os dados obtidos da API
                        dataGridView1.DataSource = dadosOriginais;

                        // Configura a ordem das colunas após carregar os dados
                        ConfigurarOrdemColunas();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao obter os dados da API. Código de status: " + response.StatusCode);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message); // Exibe mensagem em caso de erro durante a requisição
            }
        }

        // Método para configurar a ordem das colunas no DataGridView
        private void ConfigurarOrdemColunas()
        {
            // Define a ordem desejada das colunas
            string[] ordemColunas = { "Funcionario", "NomeFunc", "Imposto", "HorasTrabalhadas", "Bonus", "Data_Vigencia" };

            // Configura a ordem das colunas no DataGridView
            foreach (string nomeColuna in ordemColunas)
            {
                DataGridViewColumn coluna = dataGridView1.Columns[nomeColuna];
                if (coluna != null)
                {
                    // Configura a visibilidade da coluna
                    coluna.Visible = true;
                    // Move a coluna para a posição desejada
                    coluna.DisplayIndex = Array.IndexOf(ordemColunas, nomeColuna);
                }
            }
        }

        // Classe representando os objetos da API
        public class SeuObjeto
        {
            // Propriedades dos objetos
            public string Funcionario { get; set; }
            public string Imposto { get; set; }
            public string HorasTrabalhadas { get; set; }
            public string Bonus { get; set; }
            public DateTime Data_Vigencia { get; set; }
            public string NomeFunc { get; set; }

        }

        // Método executado ao clicar no botão de busca
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // TODO: Implemente a lógica para busca de dados
        }

        // Método executado ao clicar no botão
        private void button1_Click(object sender, EventArgs e)
        {
            // Fecha todas as instâncias da tela atual
            foreach (Form form in Application.OpenForms)
            {
                if (form is Visualizar_FolhaPagamento1)
                {
                    form.Close();
                    break; // Sair do loop depois de fechar a primeira instância (se houver mais de uma)
                }
            }

            // Verifica se a tela inicial já está aberta antes de criá-la novamente
            Tela_Inicial formLogin = Application.OpenForms.OfType<Tela_Inicial>().FirstOrDefault();

            if (formLogin == null)
            {
                // Se não estiver aberta, cria uma nova instância e a exibe
                formLogin = new Tela_Inicial();
                formLogin.Show();
            }
            else
            {
                // Se já estiver aberta, traz para a frente
                formLogin.BringToFront();
            }
        }
    }
}
