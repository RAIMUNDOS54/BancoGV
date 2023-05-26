using BancoGV.Services;

namespace BancoGV.Controllers
{
    public class ExtratoController
    {
        private readonly ExtratoService extratoService = new();

        internal async Task<Extrato> GetExtratoConsolidadoAsync(long? IdTitular, DateTime? Data)
        {
            return await extratoService.GetExtratoConsolidadoAsync(IdTitular, Data);
        }
        internal async Task<Extrato> GetExtratoConsolidadoAsync(long? IdTitular, DateTime? DataInicial, DateTime? DataFinal)
        {
            return await extratoService.GetExtratoConsolidadoAsync(IdTitular, DataInicial, DataFinal);
        }
    }
}
