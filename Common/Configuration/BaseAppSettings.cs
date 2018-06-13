using System;
using System.Configuration;

namespace Common.Configuration
{
    public abstract class BaseAppSettings
    {
        protected static string GetStringAppSettings(string key)
        {
            var value = ConfigurationManager.AppSettings[key];
            if (value == null) { throw new AppSettingNotFoundException(key); }

            return value;
        }

        public static bool TryGetAppSettingValue<TValue>(string key, out TValue value) where TValue : IConvertible
        {
            value = default(TValue);

            var sValue = ConfigurationManager.AppSettings[key];
            if (sValue == null) { return false; }

            value = (TValue)Convert.ChangeType(sValue, typeof(TValue));
            return true;
        }

        public static TValue GetAppSettingValueOrDefault<TValue>(string key, TValue defaultValue) where TValue : IConvertible
        {
            var value = default(TValue);
            var valueFound = TryGetAppSettingValue(key, out value);

            return valueFound ? value : defaultValue;
        }

        public static string GetConnectionStringOrThrowException(string key)
        {
            var value = ConfigurationManager.ConnectionStrings[key]?.ConnectionString;

            if (value == null)
                throw new ConnectionStringNotFoundException(key);

            return value;
        }
    }
}
