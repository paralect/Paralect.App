using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using Paralect.App.Test.Modules;


namespace Paralect.App.Test.Apps
{
    public class TrackerApp1 : App
    {
        protected override void Setup()
        {
            AddModule<TrackerModule1>();

            // It is possible to register modules twice
            // This call is simply ignored because such module already added
            AddModule<TrackerModule1>();

            AddModule<TrackerModule2>();            
        }
    }
}
