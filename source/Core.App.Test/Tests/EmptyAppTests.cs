using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.App.Test.Apps;
using Core.ServiceLocator;
using Microsoft.Practices.Unity;
using NUnit.Framework;

namespace Core.App.Test.Tests
{
    [TestFixture]
    public class EmptyAppTests
    {
        private IServiceLocator GetServiceLocator()
        {
            var unity = new UnityContainer();
            var locator = new Core.ServiceLocator.Unity.UnityServiceLocator(unity);
            return locator;
        }

        [Test]
        public void EmptyAppTest()
        {
            // There is no exceptions should be raised

            var app = new EmptyApp(GetServiceLocator());
            app.Start();
            app.End();
        }
    }
}
