namespace BancoGV.Models
{
    public class Extrato
    {
        public required decimal Saldo { get; set; } = 0;

        public DateTime? DataInicial { get; set; }
        public DateTime? DataFinal { get; set; }

        public required List<Lancamento> Lancamentos { get; set; }
    }
}
