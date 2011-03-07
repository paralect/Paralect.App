using Core.App.Test.Modules;
using Microsoft.Practices.Unity;

namespace Core.App.Test.Apps
{
    public class TrackerApp2 : TrackerApp1
    {
        protected override void Setup()
        {
            base.Setup();

            RemoveModule<TrackerModule1>();
        }
    }
}