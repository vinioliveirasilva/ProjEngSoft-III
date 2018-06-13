using Topshelf;
using Interface.IoC;

namespace Interface.SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {

            HostFactory.Run(c =>
            {
                c.Service<ApiHost>(svc =>
                {
                    svc.ConstructUsing(name => ApiHost.Instance);
                    svc.WhenStarted(tc => tc.Start(BindResolver.BindEverything));
                    svc.WhenStopped(tc => tc.Stop());
                });

                c.RunAsLocalSystem();

                c.EnableServiceRecovery(r => r.RestartService(1));
                c.SetDescription("Interface");
                c.SetDisplayName("Interface");
                c.SetServiceName("Interface");
            });
            
        }
    }
}
