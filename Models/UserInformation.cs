using System;
using System.ComponentModel.DataAnnotations;

namespace Club_Portal.Models
{
    public class UserInformation
    {
        [Key]
        public string UserID { get; set; }
        public string ClubID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public bool IsAdmin { get; set; }
        public Nullable<bool> IsClubAdmin { get; set; }
        public Nullable<bool> IsMember { get; set; }
        public bool IsActive { get; set; }

        public UserInformation() { }

       

        public UserInformation(string userID) : this()
        {
            this.UserID = userID;
        }

        public UserInformation(string UserName,string Password, string clubID, string userID) : this(userID)
        {
            this.UserName = UserName;
            this.ClubID = clubID;
            this.Password = Password;
        }
    }
  
}