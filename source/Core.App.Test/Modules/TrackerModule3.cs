namespace Core.App.Test.Modules
{
    public class TrackerModule3 : AppModule
    {
        public override void Start()
        {
            var counter = ServiceLocator.GetInstance<Tracker>();
            counter.ModulesInStartOrder.Add(GetType());
        }

        public override void End()
        {
            var counter = ServiceLocator.GetInstance<Tracker>();
            counter.ModulesInEndOrder.Add(GetType());
        }
    }
}