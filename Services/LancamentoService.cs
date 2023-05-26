using BancoGV.Repositories;

namespace BancoGV.Services
{
    internal class LancamentoService
    {
        private readonly LancamentoRepository lancamentoRepository = new();

        internal async Task<List<Lancamento>> GetAllLancamentosAsync()
        {
            return await lancamentoRepository.GetAllLancamentosAsync();
        }

        internal async Task<List<Lancamento>> GetAllLancamentosAsync(long? IdTitular)
        {
            return await lancamentoRepository.GetAllLancamentosAsync(IdTitular);
        }

        internal async Task<List<Lancamento>> GetAllLancamentosAsync(long? IdTitular, DateTime? Data)
        {
            return await lancamentoRepository.GetAllLancamentosAsync(IdTitular, Data);
        }

        internal async Task<Lancamento> GetLancamentoAsync(long? Id)
        {
            return await lancamentoRepository.GetLancamentoAsync(Id);
        }

        internal async Task<Lancamento> CreateLancamentoAsync(Lancamento Lancamento)
        {
            return await lancamentoRepository.CreateLancamento(Lancamento);
        }

        internal Task<bool> DeleteLancamentoAsync(long codigo)
        {
            return lancamentoRepository.DeleteLancamentoAsync(codigo);
        }

        internal Task<Lancamento> UpdateLancamentoAsync(Lancamento Lancamento)
        {
            return lancamentoRepository.UpdateLancamentoAsync(Lancamento);
        }
    }
}
