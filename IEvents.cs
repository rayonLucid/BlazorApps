using Club_Portal.Models;
using System.Collections.Generic;

namespace Club_Portal
{
    public interface IEvents
    {
        public string AddEvent(Events events);
        public void UpdateEvent(Events events);
        public IEnumerable<Events> GetAllEvents(string clubid);
        public IEnumerable<Events> GetEventInfo(int eventid);
        public IEnumerable<Events> GetExpiredEventInfo(string clubid);
        public IEnumerable<Events> GetNewEventInfo(string clubid);
        public bool Event_Subscribe(string userid,string ClubID,int EventID);
        public string Subscribe(EventSubscription eventSubscription);
        public IEnumerable<EventSubscription> Cancel_Subscribtion(EventSubscription eventSubscription);
        public bool DeleteEvent(int id);
      
    }
}
