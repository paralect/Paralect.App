using System;
using System.Collections.Generic;
using System.Text;

namespace Paralect.App
{
    /// <summary>
    /// Module definition
    /// </summary>
    public class AppModuleDefinition
    {
        /// <summary>
        /// Type of the module (for getting module instance from Service Locator)
        /// </summary>
        private Type _type;

        /// <summary>
        /// Optional key (for getting module instance from Service Locator)
        /// </summary>
        private string _key;

        /// <summary>
        /// Type of the module (for getting module instance from Service Locator)
        /// </summary>
        public Type Type
        {
            get { return _type; }
        }

        /// <summary>
        /// Optional key (for getting module instance from Service Locator)
        /// </summary>
        public String Key
        {
            get { return _key; }
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Object"/> class.
        /// </summary>
        public AppModuleDefinition(Type type, string key)
        {
            _type = type;
            _key = key;
        }
    }
}
