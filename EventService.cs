using Club_Portal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Club_Portal
{
    public class EventService:IEvents
    {
        private readonly SqlServerDbClass db;

        public Events[] AllEvents { get; private set; }
        public AllEventSubs[] clubs { get; private set; }

        public EventService(SqlServerDbClass dbClass)
        {
            db = dbClass;
        }

        public IEnumerable<AllEventSubs> GetMyEvents(int value, string clubid,string userID)
        {
            DateTime dateTime = DateTime.Now;

            try
            {

                clubs = (from evt in db.Events.Where(x => x.ClubID == clubid && x.EventDate.Value >= dateTime.Date).OrderBy(x => x.ClubID).Skip(value).Take(6)
                         join subs in db.Subscriptions.Where(x => x.ClubID == clubid && (x.Subscribed == true) && x.UserID==userID).OrderBy(x => x.ClubID)
                         on evt.ID equals subs.EventID
                       into AllEventSubs
                         from m in AllEventSubs.DefaultIfEmpty()
                         select new AllEventSubs
                         {
                             EventID = evt.ID,
                             EventName = evt.EventName,
                             EventLocation = evt.Location,
                             EventDate = evt.EventDate,
                             Description = evt.Description,
                             EventTime = evt.EventTime,
                             Subscribed = m.Subscribed,
                             SubscriptionDate = m.StartDate,
                             Cancelled = m.Cancelled,
                             CancelDate = m.CancelDate,
                             ClubID = evt.ClubID
                         }).ToArray();

            }
            catch (Exception ex)
            {

            }

            return clubs;
        }
        public IEnumerable<AllEventSubs> GetEvents(int value,string clubid)
        {
            DateTime dateTime = DateTime.Now;
        
            try {

                 clubs = (from evt in db.Events.Where(x => x.ClubID == clubid && x.EventDate.Value >= dateTime.Date).OrderBy(x => x.ClubID).Skip(value).Take(6)
                             join subs in db.Subscriptions.Where(x => x.ClubID == clubid && (x.Subscribed== false ||x.Subscribed ==null)).OrderBy(x => x.ClubID)
                             on evt.ID equals subs.EventID
                           into AllEventSubs
                             from m in AllEventSubs.DefaultIfEmpty()
                             select new AllEventSubs
                             {
                                 EventID = evt.ID,
                                 EventName = evt.EventName,
                                 EventLocation = evt.Location,
                                 EventDate = evt.EventDate,
                                 Description = evt.Description,
                                 EventTime = evt.EventTime,
                                 Subscribed = m.Subscribed,
                                 SubscriptionDate = m.StartDate,
                                 Cancelled = m.Cancelled,
                                 CancelDate = m.CancelDate,
                                 ClubID = evt.ClubID
                             }).ToArray();

            }catch (Exception ex)
            {

            }
           
            return clubs;
        }
        public string AddEvent(Events events)
        {
            string Added = String.Empty;
            try
            {
                var check = db.Events.Where(x => x.ID == events.ID).FirstOrDefault();
                if (check == null)
                {
                    db.Events.Add(events);
                    db.SaveChanges();
                    Added = "Successfull";
                }
                else
                {
                    check.EventName = events.EventName;
                    check.Location = events.Location;
                    check.Description = events.Description;
                    check.EventDate = events.EventDate;
                    db.Events.Update(check);
                    db.SaveChanges();
                    Added = "Successfull";

                }

            }
            catch (Exception ex)
            {

                Added = "Failed" + ex.Message;
            }
            return Added;
        }

        public void UpdateEvent(Events events)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Events> GetAllEvents(string clubid)
        {
            try
            {
              AllEvents = db.Events.Where(x => x.ClubID == clubid).ToArray();
            }catch (Exception ex)
            {
                AllEvents = null;
            }
            return AllEvents;
        }

        public IEnumerable<Events> GetEventInfo(int eventid)
        {
            try
            {
                AllEvents = db.Events.Where(x => x.ID == eventid).ToArray();
            }
            catch (Exception ex)
            {
                AllEvents = null;
            }
            return AllEvents;
        }

        public IEnumerable<Events> GetExpiredEventInfo(string clubid)
        {
            try
            {
                DateTime dateTime = DateTime.Now;
                AllEvents = db.Events.Where(x => x.ClubID == clubid && x.EventDate.Value < dateTime).ToArray();
            }
            catch (Exception ex)
            {
                AllEvents = null;
            }
            return AllEvents;
        }

        public IEnumerable<Events> GetNewEventInfo(string clubid)
        {
            try
            {
                DateTime dateTime = DateTime.Now;
                AllEvents = db.Events.Where(x => x.ClubID == clubid && x.EventDate.Value >= dateTime).ToArray();
            }
            catch (Exception ex)
            {
                AllEvents = null;
            }
            return AllEvents; ;
        }

        public bool Event_Subscribe(string userid,string ClubID,int EventID)
        {
            bool Result = false;
           var sub =db.Subscriptions.Where(x => x.UserID == userid && x.ClubID == ClubID && x.EventID == EventID).FirstOrDefault();
            if(sub == null)
            {
                sub.Subscribed = true;  
                sub.ClubID = ClubID;
                sub.EventID = EventID;
                sub.UserID = userid;
                sub.StartDate = DateTime.Now;
                sub.Cancelled = false;
                db.Subscriptions.Add(sub);
                db.SaveChanges();
                Result=true;

            }
            else
            {
                sub.Subscribed = true;
                sub.StartDate = DateTime.Now;
                sub.Cancelled = false;
                db.Subscriptions.Update(sub);
                db.SaveChanges();
                Result = true;
            }
            return Result;
        }

        public string Subscribe(EventSubscription eventSubscription)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EventSubscription> Cancel_Subscribtion(EventSubscription eventSubscription)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEvent(int id)
        {
            bool deleted = false;
            var userInfo = db.Events.Where(x => x.ID == id).FirstOrDefault();
            var deletedUser = db.Events.Remove(userInfo);
            if (deletedUser != null)
            {
                db.SaveChanges();
                deleted = true;
            }
            return deleted;
        }
    }
}