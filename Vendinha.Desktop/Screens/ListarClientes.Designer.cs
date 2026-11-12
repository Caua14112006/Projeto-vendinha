namespace Vendinha.Desktop.Screens
{
    partial class ListarClientes
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
            button1 = new Button();
            txtPesquisa = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            btnAnterior = new Button();
            btnProxima = new Button();
            lblPagina = new Label();
            btnEditar = new Button();
            btnDividas = new Button();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 28);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Clientes";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nome, Cpf, DataNascimento, Email, Column1, Saldo });
            dataGridView1.Location = new Point(12, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(970, 330);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // button1
            // 
            button1.Location = new Point(626, 27);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "BUSCAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(443, 28);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(179, 23);
            txtPesquisa.TabIndex = 4;
            // 
            // ListarClientes
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
            btnEditar.Name = "btnEditar";
            btnEditar.Text = "Editar cliente";
            btnEditar.Location = new Point(12, 408);
            btnEditar.Size = new Size(130, 28);
            btnEditar.Click += btnEditar_Click;
            btnDividas.Name = "btnDividas";
            btnDividas.Text = "Dívidas";
            btnDividas.Location = new Point(155, 408);
            btnDividas.Size = new Size(130, 28);
            btnDividas.Click += btnDividas_Click;
            lblStatus.Name = "lblStatus";
            lblStatus.Text = "";
            lblStatus.Location = new Point(305, 410);
            lblStatus.Size = new Size(675, 30);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 500);
            Controls.Add(lblStatus);
            Controls.Add(btnDividas);
            Controls.Add(btnEditar);
            Controls.Add(lblPagina);
            Controls.Add(btnProxima);
            Controls.Add(btnAnterior);
            Controls.Add(txtPesquisa);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "ListarClientes";
            Text = "ListarClientes";
            Load += ListarClientes_Load;
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
        
        private Button button1;
        private TextBox txtPesquisa;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Cpf;
        private DataGridViewTextBoxColumn Saldo;
        private Button btnAnterior;
        private Button btnProxima;
        private Label lblPagina;
        private Button btnEditar;
        private Button btnDividas;
        private Label lblStatus;
    }
}