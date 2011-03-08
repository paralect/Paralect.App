using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Core.App.Test.SampleApplication.Modules
{
    public class VisualStylesModule : AppModule
    {
        public override void Start()
        {
            Application.EnableVisualStyles();
        }
    }
}
