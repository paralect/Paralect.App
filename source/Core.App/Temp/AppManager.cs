using Core.ServiceLocator;

namespace Core.App.Temp
{
    public static class AppManager
    {
        public static void StartApplication<T>(IServiceLocator serviceLocator)
            where T : Temp.App
        {
            var application = serviceLocator.GetInstance<T>();
            application.StartApplication(serviceLocator);
        }

        public static void EndApplication<T>(IServiceLocator serviceLocator)
            where T : Temp.App
        {
            var application = serviceLocator.GetInstance<T>();
            application.EndApplication();
        }

        public static T GetApplication<T>(IServiceLocator serviceLocator)
            where T : Temp.App
        {
            return serviceLocator.GetInstance<T>();
        }
    }
}
