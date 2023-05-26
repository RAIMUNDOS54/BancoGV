namespace BancoGV.Configurations
{
    public class UseConfiguration : BancoGVConfiguration
    {
        public UseConfiguration()
        {
            Config();
        }

        internal override void Config()
        {
            ConfigUse();
        }

        private void ConfigUse()
        {
            UsePathbase("/api");

            Swagger2Configuration.UseSwagger();
            JWTConfiguration.UseJWT();

            Run();
        }

        private void Run()
        {
            app?.Run();
        }

        private void UsePathbase(string path)
        {
            app?.UsePathBase(new PathString(path));
        }
    }
}
