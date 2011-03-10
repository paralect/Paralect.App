using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Practices.Unity;

namespace Paralect.App
{
    public abstract class App
    {
        /// <summary>
        /// App modules definitions
        /// </summary>
        private AppModuleDefinitionCollection _definitions;

        /// <summary>
        /// App modules
        /// </summary>
        private AppModuleCollection _modules;

        /// <summary>
        /// Service Locator
        /// </summary>
        [Dependency]
        public IUnityContainer Container { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Object"/> class.
        /// </summary>
        public App()
        {
            _modules = new AppModuleCollection();
            _definitions = new AppModuleDefinitionCollection(Container);
        }

        /// <summary>
        /// App instance should override this method to configure application
        /// </summary>
        protected abstract void Setup();

        /// <summary>
        /// Start application
        /// </summary>
        public void Start()
        {
            _definitions.ClearDefinitions();
            Setup();
            StartModules();
        }

        /// <summary>
        /// End application
        /// </summary>
        public void Stop()
        {
            EndModules();
        }

        /// <summary>
        /// Start all modules in application
        /// </summary>
        protected void StartModules()
        {
            foreach (var definition in _definitions.Definitions)
            {
                var module = (AppModule) Container.Resolve(definition.Type, definition.Key);

                _modules.AddModule(module);
                module.Start();
            }
        }

        /// <summary>
        /// End all modules in application in reverse order
        /// </summary>
        protected void EndModules()
        {
            // going in reverse order
            for (var i = _modules.Items.Count - 1; i >= 0; i--)
            {
                var module = _modules.Items[i];
                module.Stop();
            }
        }

        public void AddModule<TModule>(String key = null)
            where TModule : AppModule
        {
            _definitions.AddDefinition<TModule>(key);
        }

        public void RemoveModule<TModule>(String key = null)
            where TModule : AppModule
        {
            _definitions.RemoveDefinition<TModule>(key);
        }
    }
}
