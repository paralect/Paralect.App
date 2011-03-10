using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using NUnit.Framework;
using Paralect.App.Test.Apps;

namespace Paralect.App.Test.Tests
{
    [TestFixture]
    public class EmptyAppTests
    {
        private IUnityContainer GetUnityContainer()
        {
            var unity = new UnityContainer();
            return unity;
        }

        [Test]
        public void EmptyAppTest()
        {
            // There is no exceptions should be raised
            var container = GetUnityContainer();

            AppManager.StartApp<EmptyApp>(container);
            AppManager.StopApp<EmptyApp>(container);
        }
    }
}
