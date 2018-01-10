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
        int MaxGameBoardIntLength { get; }
        int StartingValuesCount { get; }
    }

    public class AppConfig : IAppConfig
    {
        public int BoardSize => int.Parse(ConfigurationManager.AppSettings["BoardSize"]);
        public int MaxGameBoardIntLength => int.Parse(ConfigurationManager.AppSettings["MaxGameBoardIntLength"]);
        public int StartingValuesCount => int.Parse(ConfigurationManager.AppSettings["StartingValuesCount"]);
    }
}
