namespace BancoGV.Configurations
{
    public abstract class BancoGVConfiguration
    {
        protected readonly WebApplicationBuilder? builder = Program.WAB;

        protected readonly WebApplication? app = Program.WA;

        internal abstract void Config();
    }
}
