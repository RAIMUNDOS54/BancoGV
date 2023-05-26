using BancoGV.Database;

namespace BancoGV.Repositories
{
    public class ExtratoRepository
    {
        private readonly BancoGVContext dbContext = new();

        internal async Task<Extrato> GetExtratoConsolidadoAsync(long? IdTitular, DateTime? Data)
        {
            decimal saldo = 0;

            var lancamentos = await dbContext.Lancamento.Where(l => l.Titular == IdTitular && l.Data == Data).ToListAsync();

            lancamentos.ForEach(l => {
                if (l.Tipo == 1 || l.Tipo == 3)
                    saldo += l.Valor;
                else saldo -= l.Valor;
            });

            Extrato extrato = new() { Saldo = saldo, Lancamentos = lancamentos, DataInicial = Data };

            return extrato;
        }
        internal async Task<Extrato> GetExtratoConsolidadoAsync(long? IdTitular, DateTime? DataInicial, DateTime? DataFinal)
        {
            decimal saldo = 0;
            var lancamentos = await dbContext.Lancamento.Where(l => l.Titular == IdTitular && (l.Data >= DataInicial && l.Data <= DataFinal)).ToListAsync();

            lancamentos.ForEach(l => {
                if (l.Tipo == 1 || l.Tipo == 3)
                    saldo += l.Valor;
                else saldo -= l.Valor;
            });

            Extrato extrato = new() { Saldo = saldo, Lancamentos = lancamentos, DataInicial = DataInicial, DataFinal = DataFinal };

            return extrato;
        }
    }
}
