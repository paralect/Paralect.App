using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace Core.App.Test.Modules
{
    public class CultureModule : AppModule
    {
        public override void Start()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        }

        public override void Stop()
        {
            // No need to perform any cleanuping procedure...
        }
    }
}
