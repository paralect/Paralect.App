using Core.App.Test.Modules;
using Core.ServiceLocator;

namespace Core.App.Test.Apps
{
    public class TrackerApp2 : TrackerApp1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Object"/> class.
        /// </summary>
        public TrackerApp2(IServiceLocator serviceLocator) : base(serviceLocator)
        {
            RemoveModule<TrackerModule1>();
        }
    }
}