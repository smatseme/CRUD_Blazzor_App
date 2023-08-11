using CRUD_Blazzor_App.Server.Interface;
using CRUD_Blazzor_App.Server.Models;
using CRUD_Blazzor_App.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Blazzor_App.Server.Service
{
    public class UserManager : IUser
    {
        readonly DatabaseContext _dbContext = new();
        public UserManager(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Add new user
        public void AddUser(User user)
        {
            try
            {
                _dbContext.Users.Add(user);
                _dbContext.SaveChanges();
            }
            catch 
            {
                throw;
            
            }
        }

        public void DeleteUser(int id)
        {
            try
            {
                User? user = _dbContext.Users.Find(id);
                if (user != null)
                {
                    _dbContext.Users.Remove(user);
                    _dbContext.SaveChanges();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }

        public User GetUserData(int id)
        {
            try
            {
                User? user = _dbContext.Users.Find(id);
                if (user != null)
                {
                    return user;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }

        //Return all users
        public List<User> GetUserDetails()
        {
            try 
            {
                return _dbContext.Users.ToList();
            }
            catch 
            { 
                throw;
            }
        }

        public void UpdateUserDetails(User user)
        {
            try
            {
                _dbContext.Entry(user).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;

            }
        }
    }
}
