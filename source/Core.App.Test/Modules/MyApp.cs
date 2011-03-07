using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.App.Test.Modules
{
    public class MyApp : App
    {
        protected override void Setup()
        {
            AddModule<TrackerModule1>();
            AddModule<TrackerModule2>();
            AddModule<TrackerModule3>();
            AddModule<TrackerModule3>();            
        }
    }
}
