using Core.App.Test.Modules;
using Microsoft.Practices.Unity;

namespace Core.App.Test.Apps
{
    public class TrackerApp2 : TrackerApp1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Object"/> class.
        /// </summary>
        public TrackerApp2(IUnityContainer container) : base(container)
        {
            RemoveModule<TrackerModule1>();
        }
    }
}