using System;

namespace Club_Portal
{
    public class AllEventSubs
    {
        public int EventID { get; set; }
        public string EventName { get; set; }
        public string EventLocation { get; set; }
        public string Description { get; set; }
        public Nullable<DateTime> EventDate { get; set; }
        public string EventTime { get; set; }
        public Nullable<bool> Subscribed { get; set; }
        public Nullable<DateTime> SubscriptionDate { get; set; }
        public Nullable<bool> Cancelled { get; set; }
        public Nullable<DateTime>  CancelDate { get; set; }
        public string ClubID { get; set; }
    }
}