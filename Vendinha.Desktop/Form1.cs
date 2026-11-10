using Vendinha.Desktop.Screens;
using Vendinha.Services;

namespace Vendinha.Desktop
{
    public partial class Form1 : Form
    {
        private ClienteService service;
        public Form1()
        {
            service = new ClienteService();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            service = new ClienteService();
            var cadastro = new Cadastro(service);
            cadastro.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            service = new ClienteService();
            var tela = new ListarClientes(service);
            tela.ShowDialog(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            service = new ClienteService();
            var excluir = new Screens.Excluir(service);
            excluir.ShowDialog(this);
        }
    }
}
