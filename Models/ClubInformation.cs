using System;
using System.ComponentModel.DataAnnotations;

namespace Club_Portal.Models
{
    public class ClubInformation
    {
        [Key]
        public string ClubID { get; set; }
        public string ClubName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<DateTime> FoundDate { get; set; }
        public string Description { get; set; }
    }
}