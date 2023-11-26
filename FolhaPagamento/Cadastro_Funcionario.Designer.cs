namespace FolhaPagamento
{
    partial class iStorm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label12 = new Label();
            label13 = new Label();
            btnEnviar_Click = new Button();
            button2 = new Button();
            txtNome = new TextBox();
            txtCargo = new TextBox();
            txtEndereco = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtCPF = new MaskedTextBox();
            txtTelefone = new MaskedTextBox();
            txtDataNascimento = new DateTimePicker();
            txtSalario = new NumericUpDown();
            label14 = new Label();
            label15 = new Label();
            txtDepartamento = new ComboBox();
            txtDataAdmissao = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)txtSalario).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(260, 33);
            label1.Name = "label1";
            label1.Size = new Size(230, 25);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Funcionario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 109);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Nome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(493, 228);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 3;
            label4.Text = "Cargo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(85, 255);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 4;
            label5.Text = "Salario:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(85, 144);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 5;
            label6.Text = "CPF:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(85, 179);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 6;
            label7.Text = "Telefone:";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(85, 215);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 7;
            label8.Text = "Endereço:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(437, 109);
            label9.Name = "label9";
            label9.Size = new Size(105, 15);
            label9.TabIndex = 8;
            label9.Text = "Data de Admissão:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(449, 149);
            label12.Name = "label12";
            label12.Size = new Size(86, 15);
            label12.TabIndex = 11;
            label12.Text = "Departamento:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(418, 187);
            label13.Name = "label13";
            label13.Size = new Size(117, 15);
            label13.TabIndex = 12;
            label13.Text = "Data de Nascimento:";
            // 
            // btnEnviar_Click
            // 
            btnEnviar_Click.Location = new Point(656, 387);
            btnEnviar_Click.Name = "btnEnviar_Click";
            btnEnviar_Click.Size = new Size(75, 23);
            btnEnviar_Click.TabIndex = 13;
            btnEnviar_Click.Text = "Cadastrar";
            btnEnviar_Click.UseVisualStyleBackColor = true;
            btnEnviar_Click.Click += btnEnviar_Click_Click;
            // 
            // button2
            // 
            button2.Location = new Point(62, 387);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "Voltar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(145, 103);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(168, 23);
            txtNome.TabIndex = 16;
            txtNome.TextChanged += textBox2_TextChanged;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(541, 220);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(100, 23);
            txtCargo.TabIndex = 17;
            txtCargo.TextChanged += textBox3_TextChanged;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(145, 212);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(208, 23);
            txtEndereco.TabIndex = 21;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(145, 144);
            txtCPF.Mask = "00000000000";
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(100, 23);
            txtCPF.TabIndex = 28;
            txtCPF.MaskInputRejected += maskedTextBox2_MaskInputRejected;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(145, 179);
            txtTelefone.Mask = "00000000000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(100, 23);
            txtTelefone.TabIndex = 29;
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.Format = DateTimePickerFormat.Short;
            txtDataNascimento.Location = new Point(541, 181);
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.Size = new Size(96, 23);
            txtDataNascimento.TabIndex = 32;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(145, 247);
            txtSalario.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(100, 23);
            txtSalario.TabIndex = 34;
            // 
            // label14
            // 
            label14.BorderStyle = BorderStyle.FixedSingle;
            label14.Location = new Point(38, 78);
            label14.Name = "label14";
            label14.Size = new Size(727, 1);
            label14.TabIndex = 35;
            // 
            // label15
            // 
            label15.BorderStyle = BorderStyle.FixedSingle;
            label15.Location = new Point(37, 347);
            label15.Name = "label15";
            label15.Size = new Size(727, 1);
            label15.TabIndex = 36;
            // 
            // txtDepartamento
            // 
            txtDepartamento.FormattingEnabled = true;
            txtDepartamento.Items.AddRange(new object[] { "Operacional", "Gestao", "Administrativo", "RH" });
            txtDepartamento.Location = new Point(541, 144);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(121, 23);
            txtDepartamento.TabIndex = 37;
            txtDepartamento.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtDataAdmissao
            // 
            txtDataAdmissao.Format = DateTimePickerFormat.Short;
            txtDataAdmissao.Location = new Point(548, 103);
            txtDataAdmissao.Name = "txtDataAdmissao";
            txtDataAdmissao.Size = new Size(96, 23);
            txtDataAdmissao.TabIndex = 38;
            txtDataAdmissao.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // iStorm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDataAdmissao);
            Controls.Add(txtDepartamento);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(txtSalario);
            Controls.Add(txtDataNascimento);
            Controls.Add(txtTelefone);
            Controls.Add(txtCPF);
            Controls.Add(txtEndereco);
            Controls.Add(txtCargo);
            Controls.Add(txtNome);
            Controls.Add(button2);
            Controls.Add(btnEnviar_Click);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label9);
            Controls.Add(label8);
            Name = "iStorm";
            Text = "iStorm";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)txtSalario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label12;
        private Label label13;
        private Button btnEnviar_Click;
        private Button button2;
        private TextBox txtNome;
        private TextBox txtCargo;
        private TextBox txtEndereco;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MaskedTextBox txtCPF;
        private MaskedTextBox txtTelefone;
        private DateTimePicker txtDataNascimento;
        private NumericUpDown txtSalario;
        private Label label14;
        private Label label15;
        private ComboBox txtDepartamento;
        private DateTimePicker txtDataAdmissao;
    }
}