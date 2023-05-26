//using BancoGV.Database;

using BancoGV.Database;

namespace BancoGV.Configurations
{
    public class DbConfiguration : BancoGVConfiguration
    {
        private readonly string? ConnectionString;

        public DbConfiguration()
        {
            ConnectionString = builder?.Configuration?.GetSection("ConnectionStrings")["prod"]?.ToString();

            Config();
        }

        internal sealed override void Config()
        {
            DbContext();
        }

        private void DbContext() => builder?.Services.AddDbContext<BancoGVContext>(o => o.UseSqlServer(ConnectionString));
    }
}
