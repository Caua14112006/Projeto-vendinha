using Vendinha.Model;
using Vendinha.Services;

namespace Vendinha.Desktop.Screens
{
    public partial class Excluir : Form
    {
        private ClienteService service;
        private int codigoExcluir = 0;
        public Excluir(ClienteService service)
        {
            this.service = service;
            InitializeComponent();
            CarregarDados();
        }
        private List<Cliente> clientes = new List<Cliente>();
        private int pagina = 1;

        private void CarregarDados()
        {
            try
            {
                clientes = service.ConsultarPorDivida(txtPesquisa.Text);
                int paginas = (clientes.Count + 9) / 10;
                if (paginas == 0) paginas = 1;
                if (pagina > paginas) pagina = paginas;
                if (pagina < 1) pagina = 1;
                dataGridView1.Rows.Clear();
                var resultado = service.ConsultarPagina(clientes, pagina);
                foreach (var cliente in resultado)
                    dataGridView1.Rows.Add(cliente.Codigo, cliente.Nome, cliente.Cpf,
                        cliente.DataNascimento.ToString("dd/MM/yyyy"), cliente.Email ?? "",
                        cliente.Idade, service.TotalDevido(cliente.Codigo).ToString("C2"));
                lblPagina.Text = $"Página {pagina} de {paginas} | {clientes.Count} clientes | Maior saldo primeiro";
                btnAnterior.Enabled = pagina > 1;
                btnProxima.Enabled = pagina < paginas;
            }
            catch (Exception)
            {
                lblStatus.Text = "Falha na consulta. Confira a conexão e se executou o script do banco.";
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e) { pagina--; CarregarDados(); }
        private void btnProxima_Click(object sender, EventArgs e) { pagina++; CarregarDados(); }

        private int CodigoSelecionado()
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Cells[0].Value == null)
            {
                lblStatus.Text = "Selecione um cliente.";
                return 0;
            }
            var codigo = dataGridView1.CurrentRow.Cells[0].Value?.ToString();
            if (string.IsNullOrEmpty(codigo)) return 0;
            return int.Parse(codigo);
        }

        private void buttonBuscar_Click(object sender, EventArgs e) { pagina = 1; CarregarDados(); }
        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            int codigo = CodigoSelecionado();
            if (codigo == 0) return;
            codigoExcluir = codigo;
            lblStatus.Text = "Apagar cliente e TODAS as suas dívidas? Clique em Confirmar exclusão.";
            btnConfirmar.Visible = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (service.Excluir(codigoExcluir))
                {
                    lblStatus.Text = "Cliente e suas dívidas excluídos.";
                    lblStatus.ForeColor = Color.Green;
                    CarregarDados();
                    btnConfirmar.Visible = false;
                }
                else lblStatus.Text = "Cliente não encontrado.";
            }
            catch (Exception) { lblStatus.Text = "Não foi possível excluir o cliente."; }
        }
        private void Excluir_Load(object sender, EventArgs e) { }
    }
}
