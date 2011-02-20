using System;
using System.Collections.Generic;
using System.Text;
using Core.ServiceLocator;

namespace Core.App
{
    public abstract class AppModule
    {
        /// <summary>
        /// Service Locator for this module
        /// Will be injected by App
        /// </summary>
        private IServiceLocator _serviceLocator;

        /// <summary>
        /// Service Locator for this module
        /// Will be injected by App 
        /// </summary>
        public IServiceLocator ServiceLocator
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
