using Vendinha.Model;
using Vendinha.Services;
using System.ComponentModel.DataAnnotations;

namespace Vendinha.Desktop.Screens
{
    public partial class Cadastro : Form
    {
        private ClienteService service;
        private int codigo = 0;

        public Cadastro(ClienteService service)
        {
            this.service = service;
            InitializeComponent();
        }

        public Cadastro(ClienteService service, Cliente cliente) : this(service)
        {
            codigo = cliente.Codigo;
            txtCpf.Text = cliente.Cpf;
            txtNome.Text = cliente.Nome;
            txtEmail.Text = cliente.Email;
            pickerDataNascimento.Value = cliente.DataNascimento;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente
            {
                Codigo = codigo,
                Cpf = txtCpf.Text,
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                DataNascimento = pickerDataNascimento.Value.Date.ToUniversalTime()
            };
            try
            {
                bool sucesso;
                List<ValidationResult> erros;
                if (codigo == 0) sucesso = service.Criar(cliente, out erros);
                else sucesso = service.Atualizar(cliente, out erros);
                if (sucesso) this.Close();
                else
                {
                    lblStatus.Text = "";
                    lblStatus.ForeColor = Color.Red;
                    foreach (var erro in erros) lblStatus.Text += erro.ErrorMessage + " ";
                }
            }
            catch (Exception)
            {
                lblStatus.Text = "Não foi possível salvar. Confira a conexão e o CPF. Feche e abra a tela antes de tentar novamente.";
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void Cadastro_Load(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
    }
}
