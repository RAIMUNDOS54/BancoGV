using BancoGV.Repositories;

namespace BancoGV.Services
{
    public class ExtratoService
    {
        internal ExtratoRepository extratoRepository = new();

        internal async Task<Extrato> GetExtratoConsolidadoAsync(long? IdTitular, DateTime? Data)
        {
            return await extratoRepository.GetExtratoConsolidadoAsync(IdTitular, Data);
        }

        internal async Task<Extrato> GetExtratoConsolidadoAsync(long? IdTitular, DateTime? DataInicial, DateTime? DataFinal)
        {
            return await extratoRepository.GetExtratoConsolidadoAsync(IdTitular, DataInicial, DataFinal);
        }
    }
}
