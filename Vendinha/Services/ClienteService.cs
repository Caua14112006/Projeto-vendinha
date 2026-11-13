using Vendinha.Contexts;
using Vendinha.Model;
using System.ComponentModel.DataAnnotations;

namespace Vendinha.Services
{
    public class ClienteService
    {
        private VendinhaDbContext context;
        public ClienteService(VendinhaDbContext context)
        {
            this.context = context;
        }

        public ClienteService() : this(new VendinhaDbContext(ConnectionString)) { }

        // Preencha com os dados do seu PostgreSQL antes de executar.
        public const string ConnectionString =
            "Server=localhost;Port=5432;Database=vendinha;User Id=postgres;Password=SUA_SENHA;";

        public List<Cliente> Consultar()
        {
            return context.Clientes.OrderBy(c => c.Nome).ToList();
        }

        public List<Cliente> Consultar(string pesquisa)
        {
            var resultado = context.Clientes
                .Where(c => c.Nome.ToLower().Contains(pesquisa.ToLower().Trim()))
                .OrderBy(c => c.Nome);
            return resultado.ToList();
        }

        public Cliente? Consultar(int codigo)
        {
            return context.Clientes.FirstOrDefault(c => c.Codigo == codigo);
        }

        public decimal TotalDevido(int codigo)
        {
            decimal total = 0;
            var dividas = context.Dividas.Where(d => d.ClienteCodigo == codigo && !d.Paga).ToList();
            foreach (var divida in dividas) total += divida.Valor;
            return total;
        }

        public List<Cliente> ConsultarPorDivida(string pesquisa)
        {
            // A ordenação é feita na lista, usando OrderBy como no exemplo.
            var clientes = Consultar(pesquisa);
            return clientes.OrderBy(c => -TotalDevido(c.Codigo)).ToList();
        }

        public List<Cliente> ConsultarPagina(List<Cliente> clientes, int pagina)
        {
            var resultado = new List<Cliente>();
            int posicao = 0;
            int inicio = (pagina - 1) * 10;
            foreach (var cliente in clientes)
            {
                if (posicao >= inicio && posicao < inicio + 10) resultado.Add(cliente);
                posicao++;
            }
            return resultado;
        }

        public bool Criar(Cliente cliente, out List<ValidationResult> erros)
        {
            if (!Validar(cliente, out erros)) return false;
            context.Add(cliente);
            context.SaveChanges();
            return true;
        }

        public bool Atualizar(Cliente dados, out List<ValidationResult> erros)
        {
            if (!Validar(dados, out erros)) return false;
            var cliente = Consultar(dados.Codigo);
            if (cliente == null)
            {
                erros.Add(new ValidationResult("Cliente não encontrado."));
                return false;
            }
            cliente.Nome = dados.Nome;
            cliente.Cpf = dados.Cpf;
            cliente.Email = dados.Email;
            cliente.DataNascimento = dados.DataNascimento;
            context.SaveChanges();
            return true;
        }

        public bool Validar(Cliente cliente, out List<ValidationResult> erros)
        {
            cliente.Nome = cliente.Nome.Trim();
            cliente.Cpf = cliente.Cpf.Trim();
            var validacao = new ValidationContext(cliente);
            erros = new List<ValidationResult>();
            Validator.TryValidateObject(cliente, validacao, erros, true);
            if (!cliente.Nome.Contains(" ")) erros.Add(new ValidationResult("Informe nome e sobrenome."));
            if (!CpfValido(cliente.Cpf)) erros.Add(new ValidationResult("CPF inválido."));
            if (cliente.DataNascimento == default || cliente.DataNascimento.Date > DateTime.Today)
                erros.Add(new ValidationResult("Informe uma data de nascimento válida, até hoje."));

            if (cliente.Idade < 18)
            {
                erros.Add(new ValidationResult(
                    "O cliente precisa ter pelo menos 18 anos."));
            }

            if (erros.Count > 0) return false;

            var repetido = context.Clientes.FirstOrDefault(c => c.Cpf == cliente.Cpf && c.Codigo != cliente.Codigo);
            if (repetido != null) erros.Add(new ValidationResult("Este CPF já está cadastrado."));
            return erros.Count == 0;

        }

        public bool CpfValido(string cpf)
        {
            if (cpf.Length != 11) return false;
            string numeros = "0123456789";
            bool iguais = true;
            foreach (var letra in cpf)
            {
                if (!numeros.Contains(letra)) return false;
                if (letra != cpf[0]) iguais = false;
            }
            if (iguais) return false;

            int soma = 0;
            int peso = 10;
            foreach (var letra in cpf)
            {
                if (peso >= 2) soma += (letra - '0') * peso;
                peso--;
            }
            int digito = 11 - soma % 11;
            if (digito >= 10) digito = 0;
            if (cpf[9] - '0' != digito) return false;

            soma = 0;
            peso = 11;
            foreach (var letra in cpf)
            {
                if (peso >= 2) soma += (letra - '0') * peso;
                peso--;
            }
            digito = 11 - soma % 11;
            if (digito >= 10) digito = 0;
            return cpf[10] - '0' == digito;
        }

        public bool Excluir(int codigo)
        {
            var cliente = Consultar(codigo);
            if (cliente == null) return false;
            // O SQL remove as dívidas vinculadas junto com o cliente.
            context.Clientes.Remove(cliente);
            context.SaveChanges();
            return true;
        }
    }
}
