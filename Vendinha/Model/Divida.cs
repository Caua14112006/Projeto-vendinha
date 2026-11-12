namespace Vendinha.Model
{
    public class Divida
    {
        public int Codigo { get; set; }
        public int ClienteCodigo { get; set; }
        public decimal Valor { get; set; }
        public bool Paga { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataPagamento { get; set; }
    }
}
