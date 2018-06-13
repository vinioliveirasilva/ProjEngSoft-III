using Common.Configuration;
using Common.IoC;

namespace Interface.IoC
{
    public static class BindResolver
    {
        public static void BindEverything()
        {
            InstanceResolverFor<IServiceHostAppSettings>.BindSingletonOf<Configuration.AppSettings>();
        }
    }
}
