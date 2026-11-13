namespace Vendinha.Desktop.Screens
{
    partial class Dividas
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
            Nome = new DataGridViewTextBoxColumn();
            DataNascimento = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            txtPesquisa = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            btnPagar = new Button();
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
            label1.Text = "Valor (R$):";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nome, DataNascimento, Email, Column1 });
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            Email.Width = 180;
            Column1.Width = 180;
            dataGridView1.Location = new Point(12, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(759, 300);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Código";
            Codigo.Name = "Codigo";
            // 
            // Nome
            // 
            Nome.HeaderText = "Valor";
            Nome.Name = "Nome";
            // 
            // DataNascimento
            // 
            DataNascimento.HeaderText = "Situação";
            DataNascimento.Name = "DataNascimento";
            // 
            // Email
            // 
            Email.HeaderText = "Criação (UTC)";
            Email.Name = "Email";
            // 
            // Column1
            // 
            Column1.HeaderText = "Pagamento (UTC)";
            Column1.Name = "Column1";
            // 
            // button1
            // 
            button1.Location = new Point(626, 27);
            button1.Name = "button1";
            button1.Size = new Size(140, 28);
            button1.TabIndex = 3;
            button1.Text = "Cadastrar dívida";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(130, 25);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(179, 23);
            txtPesquisa.TabIndex = 4;
            // 
            // Dividas
            // 
            btnPagar.Name = "btnPagar";
            btnPagar.Text = "Registrar pagamento";
            btnPagar.Location = new Point(12, 385);
            btnPagar.Size = new Size(170, 28);
            btnPagar.Click += btnPagar_Click;
            lblStatus.Name = "lblStatus";
            lblStatus.Text = "";
            lblStatus.Location = new Point(12, 420);
            lblStatus.Size = new Size(760, 50);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 480);
            Controls.Add(lblStatus);
            Controls.Add(btnPagar);
            Controls.Add(txtPesquisa);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Dividas";
            Text = "Dividas";
            Load += Dividas_Load;
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
        private Button btnPagar;
        private Label lblStatus;
    }
}
