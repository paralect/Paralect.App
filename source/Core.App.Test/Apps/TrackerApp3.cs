using Core.App.Test.Modules;
using Core.ServiceLocator;

namespace Core.App.Test.Apps
{
    public class TrackerApp3 : TrackerApp2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Object"/> class.
        /// </summary>
        public TrackerApp3(IServiceLocator serviceLocator) : base(serviceLocator)
        {
            // Trying to remove not existing module
            RemoveModule<TrackerModule1>();

            RemoveModule<TrackerModule2>();
        }
    }
}