namespace FolhaPagamento
{
    partial class Visualizar_FolhaPagamento1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visualizar_FolhaPagamento1));
            button1 = new Button();
            label1 = new Label();
            label14 = new Label();
            label2 = new Label();
            btnEnviar_Click = new Button();
            label3 = new Label();
            txtProcurar = new TextBox();
            btnBuscar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 445);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(267, 23);
            label1.Name = "label1";
            label1.Size = new Size(194, 25);
            label1.TabIndex = 1;
            label1.Text = "Folha de Pagamento";
            // 
            // label14
            // 
            label14.BorderStyle = BorderStyle.FixedSingle;
            label14.Location = new Point(37, 78);
            label14.Name = "label14";
            label14.Size = new Size(727, 1);
            label14.TabIndex = 36;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(37, 404);
            label2.Name = "label2";
            label2.Size = new Size(727, 1);
            label2.TabIndex = 37;
            // 
            // btnEnviar_Click
            // 
            btnEnviar_Click.Location = new Point(677, 445);
            btnEnviar_Click.Name = "btnEnviar_Click";
            btnEnviar_Click.Size = new Size(96, 23);
            btnEnviar_Click.TabIndex = 38;
            btnEnviar_Click.Text = "Comprovante";
            btnEnviar_Click.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(202, 100);
            label3.Name = "label3";
            label3.Size = new Size(49, 19);
            label3.TabIndex = 41;
            label3.Text = "Buscar";
            // 
            // txtProcurar
            // 
            txtProcurar.Location = new Point(267, 100);
            txtProcurar.Name = "txtProcurar";
            txtProcurar.Size = new Size(232, 23);
            txtProcurar.TabIndex = 42;
            // 
            // btnBuscar
            // 
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 128);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = SystemColors.ActiveCaption;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(505, 100);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(49, 27);
            btnBuscar.TabIndex = 43;
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 143);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(727, 249);
            dataGridView1.TabIndex = 44;
            // 
            // Visualizar_FolhaPagamento1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(dataGridView1);
            Controls.Add(btnBuscar);
            Controls.Add(txtProcurar);
            Controls.Add(label3);
            Controls.Add(btnEnviar_Click);
            Controls.Add(label2);
            Controls.Add(label14);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Visualizar_FolhaPagamento1";
            Text = "iStorm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label14;
        private Label label2;
        private Button btnEnviar_Click;
        private Label label3;
        private TextBox txtProcurar;
        private Button btnBuscar;
        private DataGridView dataGridView1;
    }
}