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
        private IUnityContainer _serviceLocator;

        /// <summary>
        /// Service Locator for this module
        /// Will be injected by App 
        /// </summary>
        public IUnityContainer ServiceLocator
        {
            get { return _serviceLocator; }
            set { _serviceLocator = value; }
        }

        public virtual void Start()
        {
            
        }

        public virtual void End()
        {
            
        }
    }
}
