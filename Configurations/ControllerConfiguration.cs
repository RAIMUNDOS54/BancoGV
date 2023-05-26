using BancoGV.Controllers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BancoGV.Configurations
{
    internal class ControllerConfiguration : BancoGVConfiguration
    {
        internal ControllerConfiguration()
        {
            Config();
        }

        internal sealed override void Config()
        {
            ConfigAuthentication();

            ConfigLancamento();
        }

        internal void ConfigAuthentication()
        {
            app?.MapPost("/api/auth",
            async (User user) =>
            {
                return await new LoginController().LoginAsync(user);
            });
        }

        internal void ConfigLancamento()
        {
            app?.MapGet("/api/lancamentos/titular/{IdTitular}",
            [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
            async (HttpRequest request) =>
            {
                _ = long.TryParse(request.RouteValues["IdTitular"]?.ToString(), out long IdTitular);
                
                if (IdTitular == 0) throw new ArgumentException(nameof(IdTitular));

                return await new LancamentoController().GetAllLancamentosAsync(IdTitular);
            });

            app?.MapGet("/api/lancamentos/{Id}",
            [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
            async (HttpRequest request) =>
            {
                _ = long.TryParse(request.RouteValues["Id"]?.ToString(), out long Id);

                if (Id == 0) throw new ArgumentException(nameof(Id));

                return await new LancamentoController().GetLancamentoAsync(Id);
            });

            app?.MapGet("/api/extrato/consolidado/titular/{IdTitular}/{Data}",
            [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
            async (HttpRequest request) =>
            {
                _ = long.TryParse(request.RouteValues["IdTitular"]?.ToString(), out long IdTitular);
                _ = DateTime.TryParse(request.RouteValues["Data"]?.ToString(), out DateTime Data);

                if (IdTitular == 0) throw new ArgumentException(nameof(IdTitular));

                return await new ExtratoController().GetExtratoConsolidadoAsync(IdTitular, Data);
            });

            app?.MapGet("/api/extrato/consolidado/titular/{IdTitular}/{DataInicial}/{DataFinal}",
            [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
                        async (HttpRequest request) =>
            {
                _ = long.TryParse(request.RouteValues["IdTitular"]?.ToString(), out long IdTitular);
                _ = DateTime.TryParse(request.RouteValues["DataInicial"]?.ToString(), out DateTime DataInicial);
                _ = DateTime.TryParse(request.RouteValues["DataFinal"]?.ToString(), out DateTime DataFinal);

                if (IdTitular == 0) throw new ArgumentException(nameof(IdTitular));

                return await new ExtratoController().GetExtratoConsolidadoAsync(IdTitular, DataInicial, DataFinal);
            });

            app?.MapDelete("/api/lancamentos/{Id}",
            [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
            async (long Id) =>
            {
                return await new LancamentoController().DeleteLancamentoAsync(Id);
            });

            app?.MapPut("/api/lancamentos/",
                        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
            async (Lancamento Lancamento) =>
                        {
                            return await new LancamentoController().UpdateLancamentoAsync(Lancamento);
                        });

            app?.MapPost("/api/lancamentos",
            [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
            async (Lancamento Lancamento) =>
            {
                return await new LancamentoController().CreateLancamentoAsync(Lancamento);
            });
        }
    }
}
