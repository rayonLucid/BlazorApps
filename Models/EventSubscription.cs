using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Club_Portal.Models
{
    [Table("EventSubscription")]
    public class EventSubscription
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID  {get;set;}
        [Key]
        public string  UserID  {get;set;}
        [Key]
        public string  ClubID  {get;set;}
     public int  EventID  {get;set;}
     public Nullable<bool>  Subscribed  {get;set;}
     public Nullable<DateTime> StartDate  {get;set;}
     public Nullable<DateTime> EndDate  {get;set;}
     public Nullable<bool> Cancelled  {get;set;}
     public Nullable<DateTime> CancelDate  {get;set;}
    }
}
