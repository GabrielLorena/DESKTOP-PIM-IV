namespace FolhaPagamento
{
    internal static class Programa
    {
        /// <summary>
        /// Ponto de entrada principal para a aplica��o.
        /// </summary>
        [STAThread]
        static void Principal()
        {
            // Para personalizar a configura��o da aplica��o, como definir configura��es de DPI ou fonte padr�o,
            // veja https://aka.ms/applicationconfiguration.

            // Altere a linha abaixo para iniciar o formul�rio de login da sua aplica��o.
            Application.Run(new Tela_Login());
        }
    }
}
