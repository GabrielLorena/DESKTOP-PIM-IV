namespace FolhaPagamento
{
    partial class Tela_Inicial
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
            label1 = new Label();
            label14 = new Label();
            label6 = new Label();
            button1 = new Button();
            btnAcessarCadastro = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            Funcionarios = new GroupBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            Funcionarios.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(278, 9);
            label1.Name = "label1";
            label1.Size = new Size(168, 25);
            label1.TabIndex = 0;
            label1.Text = "SEJA BEM-VINDO";
            label1.Click += label1_Click;
            // 
            // label14
            // 
            label14.BorderStyle = BorderStyle.FixedSingle;
            label14.Location = new Point(37, 87);
            label14.Name = "label14";
            label14.Size = new Size(727, 1);
            label14.TabIndex = 36;
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Location = new Point(37, 352);
            label6.Name = "label6";
            label6.Size = new Size(727, 1);
            label6.TabIndex = 37;
            // 
            // button1
            // 
            button1.Location = new Point(37, 392);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 38;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnAcessarCadastro
            // 
            btnAcessarCadastro.Location = new Point(6, 22);
            btnAcessarCadastro.Name = "btnAcessarCadastro";
            btnAcessarCadastro.Size = new Size(161, 23);
            btnAcessarCadastro.TabIndex = 39;
            btnAcessarCadastro.Text = "Cadastro de Funcionarios";
            btnAcessarCadastro.UseVisualStyleBackColor = true;
            btnAcessarCadastro.Click += btnAcessarCadastro_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(6, 51);
            button3.Name = "button3";
            button3.Size = new Size(161, 23);
            button3.TabIndex = 40;
            button3.Text = "Visualizar Funcionarios";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(6, 22);
            button4.Name = "button4";
            button4.Size = new Size(188, 23);
            button4.TabIndex = 41;
            button4.Text = "Cadastro Folha de Pagamento";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(6, 51);
            button5.Name = "button5";
            button5.Size = new Size(188, 23);
            button5.TabIndex = 42;
            button5.Text = "Visualizar Folha de Pagamento";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Funcionarios
            // 
            Funcionarios.Controls.Add(btnAcessarCadastro);
            Funcionarios.Controls.Add(button3);
            Funcionarios.Location = new Point(60, 130);
            Funcionarios.Name = "Funcionarios";
            Funcionarios.Size = new Size(175, 97);
            Funcionarios.TabIndex = 44;
            Funcionarios.TabStop = false;
            Funcionarios.Text = "Funcionarios";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button5);
            groupBox1.Location = new Point(486, 130);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 45;
            groupBox1.TabStop = false;
            groupBox1.Text = "Folha de Pagamento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(290, 50);
            label2.Name = "label2";
            label2.Size = new Size(139, 17);
            label2.TabIndex = 46;
            label2.Text = "NOME DA EMPRESA";
            // 
            // Tela_Inicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(Funcionarios);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label14);
            Controls.Add(label1);
            Name = "Tela_Inicial";
            Text = "iStorm";
            Load += Tela_Inicial_Load;
            Funcionarios.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label14;
        private Label label6;
        private Button button1;
        private Button btnAcessarCadastro;
        private Button button3;
        private Button button4;
        private Button button5;
        private GroupBox Funcionarios;
        private GroupBox groupBox1;
        private Label label2;
    }
}