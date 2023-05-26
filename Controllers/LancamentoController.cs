using BancoGV.Exceptions;
using BancoGV.Services;
using BancoGV.Validators;

namespace BancoGV.Controllers
{
    internal class LancamentoController
    {
        private readonly LancamentoService lancamentoService = new();

        internal async Task<List<Lancamento>> GetAllLancamentosAsync(long? IdTitular)
        {
            return await lancamentoService.GetAllLancamentosAsync(IdTitular);
        }

        internal async Task<List<Lancamento>> GetAllLancamentosAsync(long? IdTitular, DateTime? Data)
        {
            return await lancamentoService.GetAllLancamentosAsync(IdTitular, Data);
        }

        internal async Task<Lancamento> GetLancamentoAsync(long? Id)
        {
            return await lancamentoService.GetLancamentoAsync(Id);
        }

        internal async Task<Lancamento> CreateLancamentoAsync(Lancamento Lancamento)
        {
            string strValidator = await LancamentoValidator.Validate(Lancamento);

            if (string.IsNullOrEmpty(strValidator))
            {
                return await lancamentoService.CreateLancamentoAsync(Lancamento);
            }
            else
            {
                throw new LancamentoValidationException(strValidator);
            }
        }

        internal Task<bool> DeleteLancamentoAsync(long codigo)
        {
            return lancamentoService.DeleteLancamentoAsync(codigo);
        }

        internal Task<Lancamento> UpdateLancamentoAsync(Lancamento Lancamento)
        {
            return lancamentoService.UpdateLancamentoAsync(Lancamento);
        }
    }
}