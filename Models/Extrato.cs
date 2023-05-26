namespace BancoGV.Models
{
    public class Extrato
    {
        public decimal Saldo { get; set; } = 0;

        public DateTime? DataInicial { get; set; }
        public DateTime? DataFinal { get; set; }

        public List<Lancamento> Lancamentos { get; set; }
    }
}
