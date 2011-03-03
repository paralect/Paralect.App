using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.App.Test.Apps;
using Microsoft.Practices.Unity;
using NUnit.Framework;

namespace Core.App.Test.Tests
{
    [TestFixture]
    public class EmptyAppTests
    {
        private IUnityContainer GetServiceLocator()
        {
            var unity = new UnityContainer();
            return unity;
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
