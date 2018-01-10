using System.Configuration;

namespace _2048
{
    public static class AppConstants
    {
        public static IAppConfig AppConfig => new AppConfig();
    }

    public interface IAppConfig
    {
        int BoardSize { get; }
        int BoardIntPadLength { get; }
        int StartingValuesCount { get; }
    }

    public class AppConfig : IAppConfig
    {
        public int BoardSize => int.Parse(ConfigurationManager.AppSettings["BoardSize"]);
        public int BoardIntPadLength => int.Parse(ConfigurationManager.AppSettings["BoardIntPadLength"]);
        public int StartingValuesCount => int.Parse(ConfigurationManager.AppSettings["StartingValuesCount"]);
    }
}
