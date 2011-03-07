using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;

namespace Core.App.Test.Modules
{
    public class TrackerModule1 : AppModule
    {
        public override void Start()
        {
            var tracker = Container.Resolve<Tracker>();
            tracker.ModulesInStartOrder.Add(GetType());
        }

        public override void Stop()
        {
            var tracker = Container.Resolve<Tracker>();
            tracker.ModulesInEndOrder.Add(GetType());
        }
    }
}
