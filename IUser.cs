using Club_Portal.Models;
using System.Collections.Generic;

namespace Club_Portal
{
    public interface IUser
    {
        public string AddUser(UserInformation user);
        public void UpdateUserDetails(UserInformation user);
        public IEnumerable<UserInformation> GetAllUsers(string clubid, string username);
        public IEnumerable<UserInformation> GetUserData(string userid);
        public bool DeleteUser(string id);
        public IEnumerable<ClubInformation> GetAllClubs();
    }
}
