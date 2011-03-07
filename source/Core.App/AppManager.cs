using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;

namespace Core.App
{
    /// <summary>
    /// App manager responsible for starting and application
    /// </summary>
    public class AppManager
    {
        public static TApp StartApp<TApp>(IUnityContainer container)
            where TApp : App
        {
            // Register application as singleton for this container
            container.RegisterType<TApp>(new ContainerControlledLifetimeManager());
            
            var app = container.Resolve<TApp>();
            app.Start();
            return app;
        }

        public static TApp StopApp<TApp>(IUnityContainer container)
            where TApp : App
        {
            var app = container.Resolve<TApp>();
            app.Stop();
            return app;
        }
    }
}
