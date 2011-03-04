using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.App.Test.Modules;
using Microsoft.Practices.Unity;


namespace Core.App.Test.Apps
{
    public class TrackerApp1 : App
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Object"/> class.
        /// </summary>
        public TrackerApp1(IUnityContainer container) : base(container)
        {
            AddModule<TrackerModule1>();

            // It is possible to register modules twice
            // This call is simply ignored because such module already added
            AddModule<TrackerModule1>();

            AddModule<TrackerModule2>();
        }
    }
}
