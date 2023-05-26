using BancoGV.Database;

namespace BancoGV.Repositories
{
    internal class LancamentoRepository
    {
        private readonly BancoGVContext dbContext = new();

        internal async Task<List<Lancamento>> GetAllLancamentosAsync()
        {
            return await dbContext.Lancamento.ToListAsync();
        }

        internal async Task<List<Lancamento>> GetAllLancamentosAsync(long? IdTitular)
        {
            return await dbContext.Lancamento.Where(l => l.Titular == IdTitular).ToListAsync();
        }

        internal async Task<List<Lancamento>> GetAllLancamentosAsync(long? IdTitular, DateTime? Data)
        {
            return await dbContext.Lancamento.Where(l => l.Titular == IdTitular && l.Data == Data).ToListAsync();
        }

        internal async Task<Lancamento> GetLancamentoAsync(long? Id)
        {
            return await dbContext.Lancamento.Where(l => l.Id == Id).FirstOrDefaultAsync();
        }

        internal async Task<Lancamento> CreateLancamento(Lancamento lancamento)
        {
            _ = await dbContext.Lancamento.AddAsync(lancamento);

            _ = await dbContext.SaveChangesAsync();

            return lancamento;
        }

        internal Task<bool> DeleteLancamentoAsync(long codigo)
        {
            bool blnReturn = false;

            try
            {
                dbContext.Lancamento.Remove(new Lancamento { Id = codigo });

                dbContext.SaveChangesAsync();

                blnReturn = true;
            }
            catch
            {
                blnReturn = false;
            }

            return Task.Run(() => blnReturn);
        }

        internal Task<Lancamento> UpdateLancamentoAsync(Lancamento lancamento)
        {
            dbContext.Lancamento.Update(lancamento);

            dbContext.SaveChangesAsync();

            return Task.Run(() => lancamento);
        }
    }
}
