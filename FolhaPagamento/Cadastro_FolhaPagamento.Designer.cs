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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtFuncionario = new TextBox();
            txtImposto = new TextBox();
            txtBonus = new TextBox();
            txtHorasTra = new TextBox();
            txtDataVi = new TextBox();
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
            btnEnviar_Click.Click += btnEnviar_Click_Click;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(306, 109);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 39;
            label3.Text = "Funcionario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(306, 139);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 40;
            label4.Text = "Imposto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(306, 172);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 41;
            label5.Text = "Horas Trabalhadas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(306, 210);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 42;
            label6.Text = "Bonus";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(306, 242);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 43;
            label7.Text = "Data Vigencia";
            // 
            // txtFuncionario
            // 
            txtFuncionario.Location = new Point(415, 101);
            txtFuncionario.Name = "txtFuncionario";
            txtFuncionario.Size = new Size(159, 23);
            txtFuncionario.TabIndex = 44;
            // 
            // txtImposto
            // 
            txtImposto.Location = new Point(415, 131);
            txtImposto.Name = "txtImposto";
            txtImposto.Size = new Size(100, 23);
            txtImposto.TabIndex = 45;
            // 
            // txtBonus
            // 
            txtBonus.Location = new Point(415, 202);
            txtBonus.Name = "txtBonus";
            txtBonus.Size = new Size(100, 23);
            txtBonus.TabIndex = 47;
            // 
            // txtHorasTra
            // 
            txtHorasTra.Location = new Point(415, 169);
            txtHorasTra.Name = "txtHorasTra";
            txtHorasTra.Size = new Size(100, 23);
            txtHorasTra.TabIndex = 48;
            // 
            // txtDataVi
            // 
            txtDataVi.Location = new Point(415, 242);
            txtDataVi.Name = "txtDataVi";
            txtDataVi.Size = new Size(100, 23);
            txtDataVi.TabIndex = 49;
            // 
            // Cadastro_FolhaPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDataVi);
            Controls.Add(txtHorasTra);
            Controls.Add(txtBonus);
            Controls.Add(txtImposto);
            Controls.Add(txtFuncionario);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
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
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtFuncionario;
        private TextBox txtImposto;
        private TextBox txtBonus;
        private TextBox txtHorasTra;
        private TextBox txtDataVi;
    }
}