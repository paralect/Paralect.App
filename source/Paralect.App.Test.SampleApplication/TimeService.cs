using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Paralect.App.Test.SampleApplication
{
    public abstract class TimeService
    {
        public abstract String GetTime();
    }

    public class LocalTimeService : TimeService
    {
        public override string GetTime()
        {
            return DateTime.Now.ToLongTimeString();
        }
    }

    public class UtcTimeService : TimeService
    {
        public override string GetTime()
        {
            return DateTime.UtcNow.ToLongTimeString();
        }
    }
}
