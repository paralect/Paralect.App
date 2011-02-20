using System;
using System.Collections.Generic;
using System.Text;
using Core.App.Test.Apps;
using Core.App.Test.Modules;
using Core.ServiceLocator;
using Microsoft.Practices.Unity;
using NUnit.Framework;

namespace Core.App.Test.Tests
{
    [TestFixture]
    public class TrackerAppTests
    {
        private IServiceLocator GetServiceLocator()
        {
            var unity = new UnityContainer();
            unity.RegisterInstance(new Tracker());
            var locator = new Core.ServiceLocator.Unity.UnityServiceLocator(unity);
            return locator;
        }

        [Test]
        public void TrackerApp1Test()
        {
            var locator = GetServiceLocator();
            var app = new TrackerApp1(locator);
            var tracker = locator.GetInstance<Tracker>();

            app.Start();
            Assert.AreEqual(tracker.ModulesInStartOrder.Count, 2);
            Assert.AreEqual(tracker.ModulesInStartOrder[0], typeof(TrackerModule1));
            Assert.AreEqual(tracker.ModulesInStartOrder[1], typeof(TrackerModule2));

            app.End();
            Assert.AreEqual(tracker.ModulesInEndOrder.Count, 2);
            Assert.AreEqual(tracker.ModulesInEndOrder[0], typeof(TrackerModule2));
            Assert.AreEqual(tracker.ModulesInEndOrder[1], typeof(TrackerModule1));
        }

        [Test]
        public void TrackerApp2Test()
        {
            var locator = GetServiceLocator();
            var app = new TrackerApp2(locator);
            var tracker = locator.GetInstance<Tracker>();

            app.Start();
            Assert.AreEqual(tracker.ModulesInStartOrder.Count, 1);
            Assert.AreEqual(tracker.ModulesInStartOrder[0], typeof(TrackerModule2));

            app.End();
            Assert.AreEqual(tracker.ModulesInEndOrder.Count, 1);
            Assert.AreEqual(tracker.ModulesInEndOrder[0], typeof(TrackerModule2));
        }

        [Test]
        public void TrackerApp3Test()
        {
            var locator = GetServiceLocator();
            var app = new TrackerApp3(locator);
            var tracker = locator.GetInstance<Tracker>();

            app.Start();
            Assert.AreEqual(tracker.ModulesInStartOrder.Count, 0);

            app.End();
            Assert.AreEqual(tracker.ModulesInEndOrder.Count, 0);
        }

        [Test]
        public void TrackerApp4Test()
        {
            var locator = GetServiceLocator();
            var app = new TrackerApp4(locator);
            var tracker = locator.GetInstance<Tracker>();

            app.Start();
            Assert.AreEqual(tracker.ModulesInStartOrder.Count, 3);
            Assert.AreEqual(tracker.ModulesInStartOrder[0], typeof(TrackerModule2));
            Assert.AreEqual(tracker.ModulesInStartOrder[1], typeof(TrackerModule1));
            Assert.AreEqual(tracker.ModulesInStartOrder[2], typeof(TrackerModule3));

            app.End();
            Assert.AreEqual(tracker.ModulesInEndOrder.Count, 3);
            Assert.AreEqual(tracker.ModulesInEndOrder[0], typeof(TrackerModule3));
            Assert.AreEqual(tracker.ModulesInEndOrder[1], typeof(TrackerModule1));
            Assert.AreEqual(tracker.ModulesInEndOrder[2], typeof(TrackerModule2));
        }
    }
}
