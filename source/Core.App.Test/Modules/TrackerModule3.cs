using Microsoft.Practices.Unity;

namespace Core.App.Test.Modules
{
    public class TrackerModule3 : AppModule
    {
        public override void Start()
        {
            var tracker = (Tracker) ServiceLocator.Resolve(typeof(Tracker));
            tracker.ModulesInStartOrder.Add(GetType());
        }

        public override void End()
        {
            var tracker = ServiceLocator.Resolve<Tracker>();
            tracker.ModulesInEndOrder.Add(GetType());
        }
    }
}