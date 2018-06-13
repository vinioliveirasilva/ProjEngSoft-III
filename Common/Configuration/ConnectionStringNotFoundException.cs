using System;

namespace Common.Configuration
{
    [Serializable]
    public class ConnectionStringNotFoundException : Exception
    {
        public ConnectionStringNotFoundException(string key)
            : base($"Connection string not found for key '{key}'")
        { }
    }
}