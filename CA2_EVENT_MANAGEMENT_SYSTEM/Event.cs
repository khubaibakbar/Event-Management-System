using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2_EVENT_MANAGEMENT_SYSTEM
{
    
    public class Event
    {
        public string EventType { get; set; }
        public string EventName { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public Contact Contact { get; set; }
    }

    public class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }

    public class EventManager
    {
        private List<Event> events = new List<Event>();

        public void AddEvent(Event newEvent)
        {
            events.Add(newEvent);
        }

        public List<Event> GetAllEvents()
        {
            return events;
        }
    }

}
