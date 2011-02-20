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
