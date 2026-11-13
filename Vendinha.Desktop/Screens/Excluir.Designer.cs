namespace Vendinha.Desktop.Screens
{
    partial class Excluir
    {
      
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Cpf = new DataGridViewTextBoxColumn();
            Saldo = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            DataNascimento = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            buttonBuscar = new Button();
            txtPesquisa = new TextBox();
            buttonExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            btnAnterior = new Button();
            btnProxima = new Button();
            lblPagina = new Label();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 28);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "Clientes";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nome, Cpf, DataNascimento, Email, Column1, Saldo });
            dataGridView1.Location = new Point(12, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(970, 330);
            dataGridView1.TabIndex = 2;
            // 
            // Codigo
            // 
            Cpf.HeaderText = "CPF";
            Cpf.Name = "Cpf";
            Cpf.Width = 110;
            Saldo.HeaderText = "Total em aberto";
            Saldo.Name = "Saldo";
            Nome.Width = 180;
            Email.Width = 180;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            Codigo.SortMode = DataGridViewColumnSortMode.NotSortable;
            Nome.SortMode = DataGridViewColumnSortMode.NotSortable;
            Cpf.SortMode = DataGridViewColumnSortMode.NotSortable;
            DataNascimento.SortMode = DataGridViewColumnSortMode.NotSortable;
            Email.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
            Saldo.SortMode = DataGridViewColumnSortMode.NotSortable;
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // DataNascimento
            // 
            DataNascimento.HeaderText = "Data Nascimento";
            DataNascimento.Name = "DataNascimento";
            // 
            // Email
            // 
            Email.HeaderText = "E-mail";
            Email.Name = "Email";
            // 
            // Column1
            // 
            Column1.HeaderText = "Idade";
            Column1.Name = "Column1";
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(626, 27);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(75, 23);
            buttonBuscar.TabIndex = 3;
            buttonBuscar.Text = "BUSCAR";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(443, 28);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(179, 23);
            txtPesquisa.TabIndex = 4;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Location = new Point(12, 407);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(75, 23);
            buttonExcluir.TabIndex = 5;
            buttonExcluir.Text = "EXCLUIR";
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // lblStatus
            // 
            lblStatus = new Label();
            lblStatus.AutoSize = false;
            lblStatus.Location = new Point(195, 405);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(670, 27);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "";
            lblStatus.ForeColor = Color.Black;
            // 
            // Excluir
            // 
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Text = "Anterior";
            btnAnterior.Location = new Point(12, 450);
            btnAnterior.Size = new Size(90, 28);
            btnAnterior.Click += btnAnterior_Click;
            btnProxima.Name = "btnProxima";
            btnProxima.Text = "Próxima";
            btnProxima.Location = new Point(110, 450);
            btnProxima.Size = new Size(90, 28);
            btnProxima.Click += btnProxima_Click;
            lblPagina.Name = "lblPagina";
            lblPagina.Text = "";
            lblPagina.Location = new Point(215, 455);
            lblPagina.Size = new Size(730, 25);
            btnConfirmar.Visible = false;
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Text = "Confirmar exclusão";
            btnConfirmar.Location = new Point(12, 408);
            btnConfirmar.Size = new Size(170, 28);
            btnConfirmar.Click += btnConfirmar_Click;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 500);
            Controls.Add(btnConfirmar);
            Controls.Add(lblPagina);
            Controls.Add(btnProxima);
            Controls.Add(btnAnterior);
            Controls.Add(lblStatus);
            Controls.Add(buttonExcluir);
            Controls.Add(txtPesquisa);
            Controls.Add(buttonBuscar);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Excluir";
            Text = "Excluir";
            Load += Excluir_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn DataNascimento;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Column1;
        private Button buttonBuscar;
        private TextBox txtPesquisa;
        private Button buttonExcluir;
        private Label lblStatus;
        private DataGridViewTextBoxColumn Cpf;
        private DataGridViewTextBoxColumn Saldo;
        private Button btnAnterior;
        private Button btnProxima;
        private Label lblPagina;
        private Button btnConfirmar;
    }
}