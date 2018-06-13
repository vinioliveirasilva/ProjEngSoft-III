using Common.Configuration;

namespace Interface.Configuration
{
    public class AppSettings : BaseAppSettings, IServiceHostAppSettings
    {
       string IServiceHostAppSettings.BaseAddress => GetStringAppSettings("BaseAddress");
    }
}