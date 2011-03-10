using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Practices.Unity;

namespace Paralect.App.Test.SampleApplication.Modules
{
    public class ApplicationRunnerModule : AppModule
    {
        public override void Start()
        {
            Application.Run(Container.Resolve<TimeForm>());
        }
    }
}
