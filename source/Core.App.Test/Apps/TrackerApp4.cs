using Core.App.Test.Modules;
using Core.ServiceLocator;

namespace Core.App.Test.Apps
{
    public class TrackerApp4 : TrackerApp3
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Object"/> class.
        /// </summary>
        public TrackerApp4(IServiceLocator serviceLocator) : base(serviceLocator)
        {
            AddModule<TrackerModule3>();
            AddModule<TrackerModule2>();
            AddModule<TrackerModule1>();

            // Remove and add module - this will change the order of modules
            RemoveModule<TrackerModule3>();
            AddModule<TrackerModule3>();
        }
    }
}