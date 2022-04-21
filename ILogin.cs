using Club_Portal.Models;
using System.Collections.Generic;

namespace Club_Portal
{
    public interface ILogin
    {
        public IEnumerable<UserInformation> GetUserDetails();
        public IEnumerable<ClubInformation> GetAllClubs();
        public IEnumerable<UserInformation> ValidateUser(UserInformation user);
        public void AddUser(UserInformation user);
        public void UpdateUserDetails(UserInformation user);
        public UserInformation GetUserData(int id);
        public void DeleteUser(int id);
    }
}
