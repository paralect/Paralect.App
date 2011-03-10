using Microsoft.Practices.Unity;
using Paralect.App.Test.Modules;

namespace Paralect.App.Test.Apps
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