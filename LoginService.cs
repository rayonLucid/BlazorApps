using Club_Portal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Club_Portal
{
    public class LoginService:ILogin
    {
        private readonly SqlServerDbClass db;



        public LoginService(SqlServerDbClass dbClass)
        {
            db = dbClass;
        }

        public void AddUser(UserInformation user)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteUser(int id)
        {
            throw new System.NotImplementedException();
        }

        public UserInformation GetUserData(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<UserInformation> GetUserDetails()
        {
            var users = db.UserInformation.ToArray();
             return users;
        }

        public IEnumerable<UserInformation> ValidateUser(UserInformation user)
        {
            UserInformation users = db.UserInformation.Where(x => x.UserName == user.UserName 
            && x.Password == user.Password).FirstOrDefault();
            
            yield return users;
        }

        public async Task<List<UserInformation>> GetUsersAsync()
        {
            return await db.UserInformation.ToListAsync();
        }

        public void UpdateUserDetails(UserInformation user)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<UserInformation> ValidateAsync(UserInformation user )
        {
            var users =  db.UserInformation.Where(x =>x.UserName ==user.UserName && x.Password==user.Password).FirstOrDefault();
            yield return users;
        }

        
        public string AddClubs(ClubInformation club) {
            string result = string.Empty;
            try
            {
                var clubs = db.ClubInformation.Where(x => x.ClubID == club.ClubID).FirstOrDefault();
                if (clubs == null) {
                    db.ClubInformation.Add(club);
                    db.SaveChanges();
                    result = "Success";
                        }
                else
                {
                    clubs.ClubName= club.ClubName;
                    clubs.PhoneNumber= club.PhoneNumber;
                    clubs.Email= club.Email;
                    clubs.IsActive= club.IsActive;
                    db.ClubInformation.Update(club);
                    db.SaveChanges();
                    result = "Success";
                }
            }
            catch(Exception ex)
            {
                result = "Failed :" + ex.Message;
            }
       return result;
        }
   public IEnumerable<ClubInformation> GetAllClubs()
        {
             return  db.ClubInformation.ToArray();
        }

        
    }
}