using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.ServiceLocator;

namespace Core.App.Test.Apps
{
    public class EmptyApp : App
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Object"/> class.
        /// </summary>
        public EmptyApp(IServiceLocator serviceLocator) : base(serviceLocator)
        {
        }
    }
}
