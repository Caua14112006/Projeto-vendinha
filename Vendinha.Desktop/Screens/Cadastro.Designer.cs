namespace Vendinha.Desktop.Screens
{
    partial class Cadastro
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
            txtCpf = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            pickerDataNascimento = new DateTimePicker();
            label5 = new Label();
            button1 = new Button();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(52, 156);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(200, 23);
            txtCpf.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 138);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 1;
            label1.Text = "CPF (11 números)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 182);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(52, 200);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(420, 23);
            txtNome.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 226);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 5;
            label3.Text = "E-mail";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(52, 244);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(420, 23);
            txtEmail.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 283);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 7;
            label4.Text = "Data de Nascimento";
            // 
            // pickerDataNascimento
            // 
            pickerDataNascimento.Location = new Point(52, 301);
            pickerDataNascimento.Name = "pickerDataNascimento";
            pickerDataNascimento.Size = new Size(420, 23);
            pickerDataNascimento.TabIndex = 8;
            pickerDataNascimento.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(355, 71);
            label5.Name = "label5";
            label5.Size = new Size(115, 32);
            label5.TabIndex = 9;
            label5.Text = "Cliente";
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.Location = new Point(355, 400);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblStatus
            // 
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(52, 430);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(700, 65);
            lblStatus.TabIndex = 13;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(lblStatus);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(pickerDataNascimento);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Controls.Add(txtCpf);
            Name = "Cadastro";
            Text = "Cadastro";
            Load += Cadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCpf;
        private Label label1;
        private Label label2;
        private TextBox txtNome;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private DateTimePicker pickerDataNascimento;
        private Label label5;
        private Button button1;
        private Label lblStatus;
    }
}
