using Core.App.Test.Modules;
using Microsoft.Practices.Unity;

namespace Core.App.Test.Apps
{
    public class TrackerApp3 : TrackerApp2
    {
        protected override void Setup()
        {
            base.Setup();

            // Trying to remove not existing module
            RemoveModule<TrackerModule1>();

            RemoveModule<TrackerModule2>();
        }
    }
}