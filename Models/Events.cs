using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Club_Portal.Models
{
    public class Events
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        
        public int ID  {get;set;}
      public string  EventName  {get;set;}
      public string  Location  {get;set;}
        public string Description { get; set; }
        public Nullable<DateTime>  EventDate  {get;set;}
      public string EventTime  {get;set;}
        public string ClubID { get; set; }
    }
}
