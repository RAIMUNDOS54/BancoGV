namespace BancoGV.Configurations
{
    public class AppConfiguration : BancoGVConfiguration
    {
        public static readonly string AppName = AppDomain.CurrentDomain.FriendlyName;
        public static DateTime AppVersion;

        internal override void Config()
        {
            AppVersion = DateTime.Now;
        }
    }
}
