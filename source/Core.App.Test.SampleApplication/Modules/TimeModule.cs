﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;

namespace Core.App.Test.SampleApplication.Modules
{
    public class TimeModule : AppModule
    {
        public override void Start()
        {
            // Here we are using LocalTimeService as an 
            // implementation of abstract class TimeService.
            Container.RegisterType<TimeService, LocalTimeService>();

            // Based on some condition (maybe because of configuration settings?)
            // you can make your application to use UtcTimeService:
            if (false)
                Container.RegisterType<TimeService, UtcTimeService>();
        }
    }
}
