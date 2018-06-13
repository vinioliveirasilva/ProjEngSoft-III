using System;

namespace Common.Configuration
{
    [Serializable]
    public class AppSettingNotFoundException : Exception
    {
        public AppSettingNotFoundException() { }
        public AppSettingNotFoundException(string key)
            : base(string.Format($"AppSetting not found for key: '{key}'"))
        { }
    }
}
