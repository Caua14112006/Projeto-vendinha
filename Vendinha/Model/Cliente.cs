using System.ComponentModel.DataAnnotations;

namespace Vendinha.Model
{
    public class Cliente
    {
        public int Codigo { get; set; }

        [Required(ErrorMessage = "Informe o nome completo.")]
        [StringLength(100, MinimumLength = 3)]
        public string Nome { get; set; } = "";

        [Required(ErrorMessage = "Informe o CPF.")]
        [StringLength(11, MinimumLength = 11)]
        [RegularExpression("^[0-9]+$", ErrorMessage = "O CPF deve conter somente números.")]
        public string Cpf { get; set; } = "";

        private string? email;
        [EmailAddress(ErrorMessage = "E-mail inválido.")]
        public string? Email
        {
            get { return this.email; }
            set
            {
                if (value == null) this.email = null;
                else
                {
                    var texto = value.ToLower().Trim();
                    if (string.IsNullOrEmpty(texto)) this.email = null;
                    else this.email = texto;
                }
            }
        }

        public DateTime DataNascimento { get; set; }

        public int Idade
        {
            get
            {
                var hoje = DateTime.Today;
                var idade = hoje.Year - DataNascimento.Year;
                var hojeAnoNascimento = hoje.AddYears(-idade);
                if (DataNascimento.Date > hojeAnoNascimento) idade--;
                return idade;
            }
        }
    }
}
