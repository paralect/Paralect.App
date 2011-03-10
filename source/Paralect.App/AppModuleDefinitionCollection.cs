using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Practices.Unity;

namespace Paralect.App
{
    public class AppModuleDefinitionCollection
    {
        /// <summary>
        /// List of application modules
        /// </summary>
        private List<AppModuleDefinition> _moduleDefinitions;

        /// <summary>
        /// Modules by type and key
        /// </summary>
        private Dictionary<Type, Dictionary<String, AppModuleDefinition>> _moduleDefinitionsByTypeAndKey;

        /// <summary>
        /// Default key (used when key is null)
        /// </summary>
        private const String _defaultKey = "[[CORE_DEFAULT_KEY]]";

        /// <summary>
        /// List of application modules
        /// </summary>
        public IEnumerable<AppModuleDefinition> Definitions
        {
            get { return _moduleDefinitions; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Object"/> class.
        /// </summary>
        public AppModuleDefinitionCollection(IUnityContainer serviceLocator)
        {
            _moduleDefinitions = new List<AppModuleDefinition>();
            _moduleDefinitionsByTypeAndKey = new Dictionary<Type, Dictionary<string, AppModuleDefinition>>();
        }

        /// <summary>
        /// Extend Application by adding module
        /// </summary>
        public void AddDefinition<TModule>(String key = null)
            where TModule : AppModule
        {
            var definition = new AppModuleDefinition(typeof(TModule), key);

            if (!_moduleDefinitionsByTypeAndKey.ContainsKey(typeof(TModule)))
                _moduleDefinitionsByTypeAndKey[typeof(TModule)] = new Dictionary<string, AppModuleDefinition>();

            var definitionKey = key ?? _defaultKey;

            // Silently ignore definition registration when additing already existing module definition
            if (_moduleDefinitionsByTypeAndKey[typeof(TModule)].ContainsKey(definitionKey))
                return;

            _moduleDefinitionsByTypeAndKey[typeof(TModule)][definitionKey] = definition;
            _moduleDefinitions.Add(definition);
        }

        /// <summary>
        /// Remove module from Application
        /// </summary>
        public void RemoveDefinition<TModule>(String key = null)
        {
            var definitionKey = key ?? _defaultKey;

            if (!_moduleDefinitionsByTypeAndKey.ContainsKey(typeof(TModule)))
                return;

            if (!_moduleDefinitionsByTypeAndKey[typeof(TModule)].ContainsKey(definitionKey))
                return;

            var definition = _moduleDefinitionsByTypeAndKey[typeof(TModule)][definitionKey];
            _moduleDefinitionsByTypeAndKey[typeof(TModule)].Remove(definitionKey);

            _moduleDefinitions.Remove(definition);
        }

        /// <summary>
        /// Remove all definitions from collection
        /// </summary>
        public void ClearDefinitions()
        {
            _moduleDefinitions.Clear();
            _moduleDefinitionsByTypeAndKey.Clear();
        }
    }
}
