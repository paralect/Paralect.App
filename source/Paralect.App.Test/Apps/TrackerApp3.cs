using Microsoft.Practices.Unity;
using Paralect.App.Test.Modules;

namespace Paralect.App.Test.Apps
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