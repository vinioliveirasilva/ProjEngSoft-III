using System;
using Interface.App_Start;
using Common.Configuration;
using Common.IoC;
using Microsoft.Owin.Hosting;

namespace Interface
{
    public class ApiHost
    {
        IDisposable _service;

        public static Lazy<ApiHost> _instance = new Lazy<ApiHost>(() => new ApiHost(), true);
        public static ApiHost Instance => _instance.Value;

        public void Start(Action postBinding = null)
        {
            postBinding?.Invoke();

            var appSettings = InstanceResolverFor<IServiceHostAppSettings>.Instance;
            _service = WebApp.Start<Startup>(url: appSettings.BaseAddress);
        }

        public void Stop()
        {
            _service?.Dispose();
        }
    }
}
