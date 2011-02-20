namespace Core.App.Test.Modules
{
    public class TrackerModule3 : AppModule
    {
        public override void Start()
        {
            var tracker = ServiceLocator.GetInstance<Tracker>();
            tracker.ModulesInStartOrder.Add(GetType());
        }

        public override void End()
        {
            var tracker = ServiceLocator.GetInstance<Tracker>();
            tracker.ModulesInEndOrder.Add(GetType());
        }
    }
}