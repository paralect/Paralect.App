using Core.App.Test.Modules;
using Microsoft.Practices.Unity;

namespace Core.App.Test.Apps
{
    public class TrackerApp4 : TrackerApp3
    {
        protected override void Setup()
        {
            base.Setup();

            AddModule<TrackerModule3>();
            AddModule<TrackerModule2>();
            AddModule<TrackerModule1>();

            // Remove and add module - this will change the order of modules
            RemoveModule<TrackerModule3>();
            AddModule<TrackerModule3>();
        }
    }
}