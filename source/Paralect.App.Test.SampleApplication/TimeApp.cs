using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paralect.App.Test.SampleApplication.Modules;

namespace Paralect.App.Test.SampleApplication
{
    public class TimeApp : App
    {
        protected override void Setup()
        {
            AddModule<VisualStylesModule>();
            AddModule<TextRenderingModule>();
            AddModule<TimeModule>();

            AddModule<ApplicationRunnerModule>();
        }
    }
}
