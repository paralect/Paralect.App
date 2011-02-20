using System;
using System.Collections.Generic;
using System.Text;

namespace Core.App
{
    public class AppModuleCollection
    {
        /// <summary>
        /// List of application modules
        /// </summary>
        private List<AppModule> _modules;

        /// <summary>
        /// List of application modules
        /// </summary>
        public List<AppModule> Items
        {
            get { return _modules; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Object"/> class.
        /// </summary>
        public AppModuleCollection()
        {
            _modules = new List<AppModule>();
        }

        public void AddModule(AppModule module)
        {
            _modules.Add(module);
        }
    }
}
