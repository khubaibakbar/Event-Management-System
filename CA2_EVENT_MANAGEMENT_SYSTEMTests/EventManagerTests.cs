using CA2_EVENT_MANAGEMENT_SYSTEM;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace CA2_EVENT_MANAGEMENT_SYSTEM.Tests
{
    [TestClass]
    public class EventManagerTests
    {
        [TestMethod]
        public void AddEvent()
        {
            // Arrange
            EventManager eventManager = new EventManager();
            Event newEvent = new Event
            {
                EventType = "Meeting",
                EventName = "Project Kickoff",
                Location = "Conference Room A",
                Date = DateTime.Now,
                Contact = new Contact { Name = "Taylor Swift", PhoneNumber = "+353 123 456 789", Email = "taylor@swift.com" }
            };

            // Act
            eventManager.AddEvent(newEvent);
            List<Event> events = eventManager.GetAllEvents();

            // Assert
            Assert.AreEqual(1, events.Count);
            Assert.AreEqual("Project Kickoff", events[0].EventName);
        }

        [TestMethod]
        public void GetAllEvents()
        {
            // Arrange
            EventManager eventManager = new EventManager();
            Event event1 = new Event { EventName = "Event 1", Date = DateTime.Now.AddDays(1) };
            Event event2 = new Event { EventName = "Event 2", Date = DateTime.Now.AddDays(2) };

            // Act
            eventManager.AddEvent(event1);
            eventManager.AddEvent(event2);
            List<Event> events = eventManager.GetAllEvents();

            // Assert
            Assert.AreEqual(2, events.Count);
        }
    }
}