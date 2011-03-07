using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Practices.Unity;

namespace Core.App
{
    public abstract class AppModule
    {
        /// <summary>
        /// Service Locator for this module
        /// Will be injected by App 
        /// </summary>
        [Dependency]
        public IUnityContainer Container { get; set; }

        public virtual void Start()
        {
            
        }

        public virtual void Stop()
        {
            
        }
    }
}
