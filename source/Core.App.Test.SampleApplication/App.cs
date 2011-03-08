using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.App.Test.SampleApplication.Modules;

namespace Core.App.Test.SampleApplication
{
    public class App : Core.App.App
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
