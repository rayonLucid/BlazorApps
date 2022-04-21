using Club_Portal.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Club_Portal
{
    public class UserService : IUser
    {
        private readonly SqlServerDbClass _dbClass;
        private UserInformation userInfo;

        public UserInformation[] AllUsers { get; private set; }

        public UserService(SqlServerDbClass dbClass)
        {
            _dbClass = dbClass;
        }
        public string GetNewUserID()
        {
            int TotalUserCount = _dbClass.UserInformation.Count() +1;
            string NewUserID ="User-00"+ TotalUserCount;
            return NewUserID;
        }
        public string AddUser(UserInformation user)
        {
            string Added = String.Empty;
            try
            {
                var checkuser = _dbClass.UserInformation.Where(x=>x.UserID == user.UserID).FirstOrDefault();
                if (checkuser==null)
                {
                    _dbClass.UserInformation.Add(user);
                    _dbClass.SaveChanges();
                    Added = "Successfull";
                }
                else
                {
                    checkuser.ClubID = user.ClubID;
                    checkuser.Address = user.Address;
                    checkuser.IsMember = user.IsMember;
                    checkuser.UserName=user.UserName;   
                    checkuser.Password = user.Password; 
                    checkuser.Email = user.Email;   
                    checkuser.FirstName = user.FirstName;   
                    checkuser.LastName = user.LastName;
                    checkuser.IsActive = user.IsActive;
                    checkuser.IsClubAdmin = user.IsClubAdmin;
                    checkuser.PhoneNumber = user.PhoneNumber;
                    _dbClass.UserInformation.Update(checkuser);
                    _dbClass.SaveChanges();
                    Added = "Successfull";

                }
               
            }
            catch (Exception ex) {

                Added ="Failed" + ex.Message;
            }
            return Added;
        }


        public string AddPayment(Pay payinfo)
        {
            string Added = String.Empty;
            try
            {
                
                    _dbClass.Payments.Add(payinfo);
                    _dbClass.SaveChanges();
                    Added = "Successfull";
                               

            }
            catch (Exception ex)
            {

                Added = "Failed" + ex.Message;
            }
            return Added;
        }


        public string AddClub(ClubInformation clubinfo)
        {
            string Added = String.Empty;
            try
            {
                var check =_dbClass.ClubInformation.Where(x=>x.ClubID==clubinfo.ClubID).FirstOrDefault();
                if(check==null)
                {
                    _dbClass.ClubInformation.Add(clubinfo);
                    _dbClass.SaveChanges();
                    Added = "Successfull";
                }
                else
                {
                    check.ClubName = clubinfo.ClubName;
                    check.PhoneNumber = clubinfo.PhoneNumber;   
                    check.Email = clubinfo.Email;
                    check.IsActive = clubinfo.IsActive;
                    _dbClass.ClubInformation.Update(check);
                    _dbClass.SaveChanges();
                    Added = "Successfull";

                }
               
            }
            catch (Exception ex)
            {

                Added = "Failed" + ex.Message;
            }
            return Added;
        }

        public bool DeleteUser(string id)
        {
            bool deleted = false;
            var userInfo = _dbClass.UserInformation.Where(x=>x.UserID ==id).FirstOrDefault();
            var deletedUser = _dbClass.UserInformation.Remove(userInfo);
            if (deletedUser != null)
            {
                _dbClass.SaveChanges();
                deleted = true;
            }
            return deleted;
        }
        public IEnumerable<ClubInformation> GetActiveClubsInfo(string clubid)
        {
            var clubs = _dbClass.ClubInformation.Where(x => x.ClubName != "Default" && x.ClubID== clubid).ToArray();
            return clubs;
        }
        
             public IEnumerable<ClubInformation> GetClubs(int value)
        {
            var clubs = _dbClass.ClubInformation.Where(x => x.ClubName != "Default").OrderBy(x => x.ClubID).Skip(value).Take(6).ToArray();
            return clubs;
        }
        public IEnumerable<ClubInformation> GetNextClubs()
        {
            var clubs = _dbClass.ClubInformation.Where(x => x.ClubName != "Default").OrderBy(x => x.ClubID).Skip(1).Take(3).ToArray();
            return clubs;
        }
        public IEnumerable<ClubInformation> GetAllClubs()
        {
            var clubs = _dbClass.ClubInformation.Where(x => x.ClubName != "Default").OrderBy(x=>x.ClubID).ToArray();
            return clubs;
        }
        public int GetActiveMembers(string clubid)
        {
            int count = 0;
            try
            {
                count = _dbClass.UserInformation.Where(x => x.IsActive == true && x.ClubID==clubid && x.IsClubAdmin ==false).ToArray().Count();
            }
            catch (Exception ex) { }

            return count;


        }
        public int GetAllMembersCount(string clubid)
        {
            int count = 0;
            try { count = _dbClass.UserInformation.Where(x => x.ClubID != "DEFAULT" && x.ClubID==clubid && x.IsClubAdmin == false).ToArray().Count(); } catch (Exception ex) { }
            return count;
        }
        public int GetInActivenenbers(string clubid)
        {
            int count = 0;
            try
            {
                count = _dbClass.UserInformation.Where(x => x.IsActive == false && x.ClubID==clubid && x.IsClubAdmin == false).ToArray().Count();
            }
            catch (Exception ex) { }
            return count;
        }
        public int GetActiveClubs(string clubid)
        {
            int count = 0;
            try
            {
                count = _dbClass.ClubInformation.Where(x =>  x.IsActive == true).ToArray().Count();
            }
            catch (Exception ex) { }
           
            return count;


        }
        public int GetAllCountClubs()
        {
            int count = 0;
            try { count =_dbClass.ClubInformation.Where(x=>x.ClubID!="DEFAULT").ToArray().Count(); }catch (Exception ex) { }
            return count;
        }
        public int GetInActiveClubs(string clubid)
        {
            int count = 0;
            try
            {
                count = _dbClass.ClubInformation.Where(x => x.IsActive == false).ToArray().Count();
            }catch (Exception ex) { }
            return count;
        }
        public IEnumerable<UserInformation> GetAllMembers(string clubid)
        {
            return _dbClass.UserInformation.Where(x=>x.ClubID == clubid).ToArray();
        }


        public IEnumerable<UserInformation> GetAllUsers(string clubid,string username)
        {
            if (username != "MASTER")
            {
                AllUsers = _dbClass.UserInformation.Where(x => x.ClubID == clubid).ToArray();
            }
            else
            {
                AllUsers = _dbClass.UserInformation.Where(x => x.UserName != "MASTER" && x.IsMember==false).ToArray();
            }
            return AllUsers;
        }

        public IEnumerable<UserInformation> GetUserData(string id)
        {
          //  IEnumerable<UserInformation> userInfo = null;
            try
            {
                userInfo = _dbClass.UserInformation.Where(x => x.UserID == id).FirstOrDefault();
            }catch(Exception ex) { }
             
            yield return userInfo;
        }

        public void UpdateUserDetails(UserInformation user)
        {
            throw new System.NotImplementedException();
        }

      
    }
}
