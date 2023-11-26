namespace FolhaPagamento
{
    partial class Cadastro_FolhaPagamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            btnEnviar_Click = new Button();
            label14 = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(30, 400);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnEnviar_Click
            // 
            btnEnviar_Click.Location = new Point(685, 400);
            btnEnviar_Click.Name = "btnEnviar_Click";
            btnEnviar_Click.Size = new Size(75, 23);
            btnEnviar_Click.TabIndex = 14;
            btnEnviar_Click.Text = "Cadastrar";
            btnEnviar_Click.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.BorderStyle = BorderStyle.FixedSingle;
            label14.Location = new Point(30, 353);
            label14.Name = "label14";
            label14.Size = new Size(727, 1);
            label14.TabIndex = 36;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(33, 66);
            label1.Name = "label1";
            label1.Size = new Size(727, 1);
            label1.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(231, 23);
            label2.Name = "label2";
            label2.Size = new Size(278, 25);
            label2.TabIndex = 38;
            label2.Text = "Cadastro Folha de Pagamento";
            // 
            // Cadastro_FolhaPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label14);
            Controls.Add(btnEnviar_Click);
            Controls.Add(button1);
            Name = "Cadastro_FolhaPagamento";
            Text = "iStorm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnEnviar_Click;
        private Label label14;
        private Label label1;
        private Label label2;
    }
}