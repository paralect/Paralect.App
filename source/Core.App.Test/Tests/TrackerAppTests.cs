using System;
using System.Collections.Generic;
using System.Text;
using Core.App.Test.Apps;
using Core.App.Test.Modules;
using Microsoft.Practices.Unity;
using NUnit.Framework;

namespace Core.App.Test.Tests
{
    [TestFixture]
    public class TrackerAppTests
    {
        private IUnityContainer GetUnityContainer()
        {
            var unity = new UnityContainer();
            unity.RegisterInstance(new Tracker());
            return unity;
        }

        [Test]
        public void TrackerApp1Test()
        {
            var container = GetUnityContainer();
            var tracker = container.Resolve<Tracker>();

            AppManager.StartApp<TrackerApp1>(container);
            Assert.AreEqual(tracker.ModulesInStartOrder.Count, 2);
            Assert.AreEqual(tracker.ModulesInStartOrder[0], typeof(TrackerModule1));
            Assert.AreEqual(tracker.ModulesInStartOrder[1], typeof(TrackerModule2));

            AppManager.StopApp<TrackerApp1>(container);
            Assert.AreEqual(tracker.ModulesInEndOrder.Count, 2);
            Assert.AreEqual(tracker.ModulesInEndOrder[0], typeof(TrackerModule2));
            Assert.AreEqual(tracker.ModulesInEndOrder[1], typeof(TrackerModule1));
        }

        [Test]
        public void TrackerApp2Test()
        {
            var container = GetUnityContainer();
            var tracker = container.Resolve<Tracker>();

            AppManager.StartApp<TrackerApp2>(container); 
            Assert.AreEqual(tracker.ModulesInStartOrder.Count, 1);
            Assert.AreEqual(tracker.ModulesInStartOrder[0], typeof(TrackerModule2));

            AppManager.StopApp<TrackerApp2>(container); 
            Assert.AreEqual(tracker.ModulesInEndOrder.Count, 1);
            Assert.AreEqual(tracker.ModulesInEndOrder[0], typeof(TrackerModule2));
        }

        [Test]
        public void TrackerApp3Test()
        {
            var container = GetUnityContainer();
            var tracker = container.Resolve<Tracker>();

            AppManager.StartApp<TrackerApp3>(container); 
            Assert.AreEqual(tracker.ModulesInStartOrder.Count, 0);

            AppManager.StopApp<TrackerApp3>(container);
            Assert.AreEqual(tracker.ModulesInEndOrder.Count, 0);
        }

        [Test]
        public void TrackerApp4Test()
        {
            var container = GetUnityContainer();
            var tracker = container.Resolve<Tracker>();

            AppManager.StartApp<TrackerApp4>(container);
            Assert.AreEqual(tracker.ModulesInStartOrder.Count, 3);
            Assert.AreEqual(tracker.ModulesInStartOrder[0], typeof(TrackerModule2));
            Assert.AreEqual(tracker.ModulesInStartOrder[1], typeof(TrackerModule1));
            Assert.AreEqual(tracker.ModulesInStartOrder[2], typeof(TrackerModule3));

            AppManager.StopApp<TrackerApp4>(container);
            Assert.AreEqual(tracker.ModulesInEndOrder.Count, 3);
            Assert.AreEqual(tracker.ModulesInEndOrder[0], typeof(TrackerModule3));
            Assert.AreEqual(tracker.ModulesInEndOrder[1], typeof(TrackerModule1));
            Assert.AreEqual(tracker.ModulesInEndOrder[2], typeof(TrackerModule2));
        }
    }
}
