using Vendinha.Services;

namespace Vendinha.Desktop.Screens
{
    public partial class Dividas : Form
    {
        private DividaService service;
        private int clienteCodigo;

        public Dividas(int clienteCodigo)
        {
            this.clienteCodigo = clienteCodigo;
            service = new DividaService();
            InitializeComponent();
            Text = "Dívidas do cliente " + clienteCodigo;
            CarregarDados();
        }

        private void CarregarDados()
        {
            try
            {
                dataGridView1.Rows.Clear();
                var dividas = service.Consultar(clienteCodigo);
                foreach (var divida in dividas)
                {
                    var situacao = "Em aberto";
                    if (divida.Paga) situacao = "Paga";
                    var pagamento = "";
                    if (divida.DataPagamento != null)
                        pagamento = divida.DataPagamento.Value.ToString("dd/MM/yyyy HH:mm");
                    dataGridView1.Rows.Add(divida.Codigo, divida.Valor.ToString("C2"),
                        situacao, divida.DataCriacao.ToString("dd/MM/yyyy HH:mm"), pagamento);
                }
            }
            catch (Exception) { lblStatus.Text = "Não foi possível consultar as dívidas."; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var valor = decimal.Parse(txtPesquisa.Text);
                if (service.Criar(clienteCodigo, valor, out var erro))
                {
                    lblStatus.Text = "Dívida cadastrada.";
                    txtPesquisa.Text = "";
                    CarregarDados();
                }
                else lblStatus.Text = erro;
            }
            catch (OverflowException) { lblStatus.Text = "Valor fora dos limites."; }
            catch (Exception) { lblStatus.Text = "Não foi possível cadastrar. Confira valor (ex.: 25,50), conexão e dívida em aberto. Feche e abra a tela para tentar novamente."; }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Cells[0].Value == null)
            { lblStatus.Text = "Selecione uma dívida."; return; }
            try
            {
                var texto = dataGridView1.CurrentRow.Cells[0].Value?.ToString();
                if (string.IsNullOrEmpty(texto)) return;
                int codigo = int.Parse(texto);
                if (service.Pagar(codigo, out var erro))
                { lblStatus.Text = "Pagamento registrado."; CarregarDados(); }
                else lblStatus.Text = erro;
            }
            catch (Exception) { lblStatus.Text = "Não foi possível registrar o pagamento."; }
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void Dividas_Load(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
