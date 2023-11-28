namespace FolhaPagamento
{
    internal static class Programa
    {
        /// <summary>
        /// Ponto de entrada principal para a aplicação.
        /// </summary>
        [STAThread]
        static void Principal()
        {
            // Para personalizar a configuração da aplicação, como definir configurações de DPI ou fonte padrão,
            // veja https://aka.ms/applicationconfiguration.

            // Altere a linha abaixo para iniciar o formulário de login da sua aplicação.
            Application.Run(new Tela_Login());
        }
    }
}
