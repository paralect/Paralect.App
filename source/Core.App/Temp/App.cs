using System;
using System.Collections.Generic;
using Core.ServiceLocator;

namespace Core.App.Temp
{
    /// <summary>
    /// Object represent one application 
    /// </summary>
    public class App
    {
        /// <summary>
        /// Unity Container
        /// </summary>
        public IServiceLocator ServiceLocator { get; set; }

        /// <summary>
        /// List of application modules
        /// </summary>
        private List<IAppModule> modules;

        /// <summary>
        /// Modules by name
        /// </summary>
        public Dictionary<String, IAppModule> modulesByName;

        /// <summary>
        /// Application start
        /// </summary>
        public event EventHandler Start;

        /// <summary>
        /// Application end
        /// </summary>
        public event EventHandler End;

        /// <summary>
        /// Initialization
        /// </summary>
        protected void InitApplication()
        {
            modules = new List<IAppModule>(50);
            modulesByName = new Dictionary<string, IAppModule>(50);
        }

        /// <summary>
        /// Initiate starting of application
        /// </summary>
        /// <param name="serviceLocator"></param>
        public virtual void StartApplication(IServiceLocator serviceLocator)
        {
            try
            {
                InitApplication();
                SetupModules();
                InitModules();

                if (Start != null)
                    Start(this, EventArgs.Empty);
            }
            catch (Exception e)
            {
//                log.Error("Error when launching application", e);
                throw;
            }

        }

        /// <summary>
        /// Initiate end of application
        /// </summary>
        public virtual void EndApplication()
        {
            if (End != null)
                End(this, EventArgs.Empty);
        }

        /// <summary>
        /// Initialize all modules
        /// </summary>
        private void InitModules()
        {
            foreach (var module in modules)
            {
                module.Init(this);
            }
        }

        /// <summary>
        /// Template method for module configuration
        /// </summary>
        protected virtual void SetupModules()
        {
//            AddModule<ConfigurationModule>();
        }

        /// <summary>
        /// Extend Application by adding module
        /// </summary>
        protected void AddModule<TModule>(String name = null)
            where TModule : IAppModule
        {
            var actualName = name ?? typeof(TModule).FullName;

            var module = ServiceLocator.GetInstance<TModule>();
            modulesByName.Add(actualName, module);
            modules.Add(module);
        }

        /// <summary>
        /// Remove module from Application
        /// </summary>
        protected void RemoveModule<TModule>(String name = null)
        {
            var actualName = name ?? typeof(TModule).FullName;

            var module = modulesByName[actualName];
            modules.Remove(module);
            modulesByName.Remove(actualName);
        }
    }
}
