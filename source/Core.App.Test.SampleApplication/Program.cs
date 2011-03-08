using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Core.App.Test.SampleApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppManager.StartApp<App>(AppDomainUnityContext.Current);
        }
    }
}
