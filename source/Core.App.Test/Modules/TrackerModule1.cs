using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.ServiceLocator;

namespace Core.App.Test.Modules
{
    public class TrackerModule1 : AppModule
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
