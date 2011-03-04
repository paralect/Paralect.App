﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Practices.Unity;

namespace Core.App
{
    public abstract class App
    {
        /// <summary>
        /// Service Locator
        /// </summary>
        private readonly IUnityContainer _container;

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
        public IUnityContainer Container
        {
            get { return _container; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Object"/> class.
        /// </summary>
        public App(IUnityContainer container)
        {
            _container = container;
            _modules = new AppModuleCollection();
            _definitions = new AppModuleDefinitionCollection(_container);
        }

        /// <summary>
        /// Start application
        /// </summary>
        public void Start()
        {
            StartModules();
        }

        /// <summary>
        /// End application
        /// </summary>
        public void End()
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
                var module = (AppModule) _container.Resolve(definition.Type, definition.Key);

                // Injection of ServiceLocator
                module.Container = _container;

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
                module.End();
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
