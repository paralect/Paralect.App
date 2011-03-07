using Microsoft.Practices.Unity;

namespace Core.App.Test.Modules
{
    public class TrackerModule3 : AppModule
    {
        public override void Start()
        {
            var tracker = (Tracker) Container.Resolve(typeof(Tracker));
            tracker.ModulesInStartOrder.Add(GetType());
        }

        public override void Stop()
        {
            var tracker = Container.Resolve<Tracker>();
            tracker.ModulesInEndOrder.Add(GetType());
        }
    }
}