﻿using Newtonsoft.Json; // Biblioteca para trabalhar com JSON
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
                HttpClient client = new HttpClient(); // Cliente para fazer requisições HTTP
                HttpResponseMessage response = await client.GetAsync(apiUrl); // Faz a requisição GET para a API

                if (response.IsSuccessStatusCode) // Se a requisição foi bem-sucedida
                {
                    string json = await response.Content.ReadAsStringAsync(); // Lê o conteúdo da resposta como uma string JSON
                    dadosOriginais = JsonConvert.DeserializeObject<List<SeuObjeto>>(json); // Converte o JSON para uma lista de objetos

                    // Popula o DataGridView com os dados obtidos da API
                    dataGridView1.DataSource = dadosOriginais;
                }
                else
                {
                    MessageBox.Show("Falha ao obter os dados da API. Código de status: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message); // Exibe mensagem em caso de erro durante a requisição
            }
        }

        // Classe representando os objetos da API
        public class SeuObjeto
        {
            // Propriedades dos objetos
            public int Funcionario { get; set; }
            public string Imposto { get; set; }
            public string HorasTrabalhadas { get; set; }
            public decimal Bonus { get; set; }
            public string data_vigencia { get; set; }
        }

        // Método executado ao clicar no botão de busca
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string termoBusca = txtProcurar.Text.ToLower(); // Obtém o termo de busca em letras minúsculas

            if (!string.IsNullOrWhiteSpace(termoBusca)) // Se o termo de busca não estiver vazio
            {
                // Filtra os dados originais com base no termo de busca
                List<SeuObjeto> resultadosFiltrados = dadosOriginais
                    .Where(o =>
                        o.Funcionario.ToLower().Contains(termoBusca) ||
                        o.Imposto.ToLower().Contains(termoBusca) ||
                        o.HorasTrabalhadas.ToLower().Contains(termoBusca) ||
                        o.Bonus.ToLower().Contains(termoBusca)
                    // Adicione outras propriedades que deseja incluir no filtro
                    )
                    .ToList();

                // Atualiza o DataGridView com os resultados filtrados
                dataGridView1.DataSource = resultadosFiltrados;
            }
            else
            {
                // Se a caixa de busca estiver vazia, exibe todos os dados originais
                dataGridView1.DataSource = dadosOriginais;
            }
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