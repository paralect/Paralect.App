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
        private IUnityContainer _container;

        /// <summary>
        /// Service Locator for this module
        /// Will be injected by App 
        /// </summary>
        public IUnityContainer Container
        {
            get { return _container; }
            set { _container = value; }
        }

        public virtual void Start()
        {
            
        }

        public virtual void End()
        {
            
        }
    }
}
